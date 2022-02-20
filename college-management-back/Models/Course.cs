using college_management_back.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace college_management_back.Models
{
    public class Course
    {
        public Course()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Subject> Subjects{ get; set; }
    }
}