using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class CoursesList
    {
        public Dictionary<int, CourseItem> Courses { get; set; }

        public CoursesList()
        {
            Courses = new Dictionary<int, CourseItem>();
        }

        public void Add(int identifier, CourseItem course)
        {
            if (Courses.ContainsKey(identifier))
            {
                return;
            }

            Courses.Add(identifier, course);
        }
    }
}