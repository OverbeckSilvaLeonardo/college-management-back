using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class FormattedCoursesList
    {
        public Dictionary<int, FormattedCourseItem> CoursesList { get; set; }

        public FormattedCoursesList()
        {
            CoursesList = new Dictionary<int, FormattedCourseItem>();
        }

        public void Add(int identifier, FormattedCourseItem course)
        {
            if (CoursesList.ContainsKey(identifier))
            {
                return;
            }

            CoursesList.Add(identifier, course);
        }
    }
}