using BusinessLogic.Enums;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace BusinessLogic.ViewModels
{
    [DataContract]
    public class StudentViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("ФИО студента")]
        public string FIO { get; set; }

        [DataMember]
        [DisplayName("Форма обучения")]
        public FormEducation FormEducation { get; set; }

        [DataMember]
        [DisplayName("Электронная почта")]
        public string Email { get; set; }
    }
}
