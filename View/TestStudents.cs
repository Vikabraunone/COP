using System;

namespace View
{
    public static class TestStudents
    {
        public static Student[] Students = new Student []
        { 
            new Student
            {
                FIO = "Иванов Иван Иванович",
                Age = 18, 
                Course = 1,
                DateBirth = new DateTime(2001, 5, 1)
            },
            new Student
            {
                FIO = "Петров Алексей Федорович",
                Age = 19,
                Course = 2,
                DateBirth = new DateTime(2000, 8, 13)
            },
            new Student
            {
                FIO = "Соколова Анастасия Валентиновна",
                Age = 21,
                Course = 4,
                DateBirth = new DateTime(1999, 4, 20)
            }
        };
    }
}
