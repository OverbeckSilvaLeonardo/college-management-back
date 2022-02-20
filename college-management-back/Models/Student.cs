using System.Collections.Generic;
using college_management_back.Models.Interface;
using Newtonsoft.Json;

namespace college_management_back.Models
{
    public class Student : Person, IPerson
    {
        public Student()
        {
        }

        public int StudentID { get; set; }
        public string RegistrationNumber { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}