using BusinessLogic.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DatabaseModels
{
    public class StudentDatabaseModel
    {
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        [Required]
        public FormEducation FormEducation { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
