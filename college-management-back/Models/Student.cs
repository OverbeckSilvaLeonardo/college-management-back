using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using college_management_back.Domain.Person;
using college_management_back.Models.Interface;

namespace college_management_back.Models
{
    public class Student : Person, IPerson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public string RegistrationNumber { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}