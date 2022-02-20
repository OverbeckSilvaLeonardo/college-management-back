using college_management_back.Domain.Api.Common;
using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses
{
    public class CoursesList
    {
        public Dictionary<int, CoursesListItem> Courses { get; set; }

        public CoursesList()
        {
            Courses = new Dictionary<int, CoursesListItem>();
        }

        public static CoursesList FromCoursesList(List<Course> courses)
        {
            var result = new CoursesList();

            courses.ForEach(course =>
            {
                var studentsList = StudentsList.FromDatabaseSubjectsList(course.Subjects.ToList());
                var teacherCount = TeacherCount.FromSubjectsList(course.Subjects.ToList());
                var item = new CoursesListItem { CourseID = course.CourseID, Description = course.Description, TeacherCount = teacherCount.Count, StudentCount = studentsList.Count(), StudentsList = studentsList };

                result.Add(course.CourseID, item);
            });

            return result;
        }

        public void Add(int identifier, CoursesListItem course)
        {
            if (Courses.ContainsKey(identifier))
            {
                return;
            }

            Courses.Add(identifier, course);
        }
    }
}