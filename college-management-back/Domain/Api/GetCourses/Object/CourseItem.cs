using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class CourseItem
    {
        public CourseItem()
        {
        }

        public int CourseID { get; set; }
        public string Description { get; set; }
        public StudentsList StudentsList { get; set; }
    }
}