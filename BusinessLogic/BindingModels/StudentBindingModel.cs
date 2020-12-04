using BusinessLogic.Enums;
using System.Runtime.Serialization;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class StudentBindingModel
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string FIO { get; set; }

        [DataMember]
        public FormEducation FormEducation { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
