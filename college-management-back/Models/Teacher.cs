using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using college_management_back.Models.Interface;

namespace college_management_back.Models
{
    public class Teacher : Person, IPerson
    {
        public Teacher()
        {
        }

        public int TeacherID { get; set; }
        public decimal Salary { get; set; }
    }
}