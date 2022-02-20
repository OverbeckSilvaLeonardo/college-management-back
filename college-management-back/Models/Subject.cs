using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using college_management_back.Models.Interface;

namespace college_management_back.Models
{
    public class Subject
    {
        public Subject()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string Description { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}