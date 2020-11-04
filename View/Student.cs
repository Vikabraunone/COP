using System;
using System.Runtime.Serialization;

namespace View
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string FIO;

        [DataMember]
        public int Age;

        [DataMember]
        public int Course;

        [DataMember]
        public DateTime? DateBirth;
    }
}
