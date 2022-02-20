using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class FormattedCourseItem
    {
        public FormattedCourseItem()
        {
        }

        public int CourseID { get; set; }
        public string Description { get; set; }
        public FormattedStudentsList StudentsList { get; set; }
    }
}