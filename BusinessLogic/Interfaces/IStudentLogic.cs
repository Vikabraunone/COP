using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IStudentLogic
    {
        List<StudentViewModel> Read(StudentBindingModel model);

        void CreateOrUpdate(StudentBindingModel model);

        void Delete(StudentBindingModel model);
    }
}
