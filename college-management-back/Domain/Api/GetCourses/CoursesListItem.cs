using college_management_back.Domain.Api.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses
{
    public class CoursesListItem
    {
        public int CourseID { get; set; }
        public string Description { get; set; }
        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }
        public StudentsList StudentsList { get; set; }
    }
}