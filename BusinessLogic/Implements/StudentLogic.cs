using BusinessLogic.BindingModels;
using BusinessLogic.DatabaseModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Implements
{
    public class StudentLogic : IStudentLogic
    {
        public void CreateOrUpdate(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                StudentDatabaseModel element = context.StudentsDatabaseModel.FirstOrDefault(rec => rec.Email == model.Email && rec.Id != model.Id);
                if (element != null)
                    throw new Exception("Уже есть студент с такой электронной почтой");
                if (model.Id.HasValue)
                {
                    element = context.StudentsDatabaseModel.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                        throw new Exception("Элемент не найден");
                }
                else
                {
                    element = new StudentDatabaseModel();
                    context.StudentsDatabaseModel.Add(element);
                }
                element.FIO = model.FIO;
                element.FormEducation = model.FormEducation;
                element.Email = model.Email;
                context.SaveChanges();
            }
        }

        public void Delete(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                StudentDatabaseModel element = context.StudentsDatabaseModel.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.StudentsDatabaseModel.Remove(element);
                    context.SaveChanges();
                }
                else
                    throw new Exception("Элемент не найден");
            }
        }

        public List<StudentViewModel> Read(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                return context.StudentsDatabaseModel
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new StudentViewModel
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    FormEducation = rec.FormEducation,
                    Email = rec.Email
                })
                .OrderBy(x => x.FIO)
                .ToList();
            }
        }
    }
}
