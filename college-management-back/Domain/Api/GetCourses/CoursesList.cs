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
        public new List<CoursesListItem> Courses { get; set; }

        public CoursesList()
        {
            Courses = new List<CoursesListItem>();
        }

        public static CoursesList FromCoursesList(List<Course> courses)
        {
            var result = new CoursesList();

            courses.ForEach(course =>
            {
                var studentsList = StudentsList.FromDatabaseSubjectsList(course.Subjects.ToList());
                var teacherCount = TeacherCount.FromSubjectsList(course.Subjects.ToList());
                var item = new CoursesListItem { CourseID = course.CourseID, Description = course.Description, TeacherCount = teacherCount.Count, StudentCount = studentsList.Count(), StudentsList = studentsList };

                result.Courses.Add(item);
            });

            return result;
        }

        private void Add(CoursesListItem course)
        {
            foreach (var item in Courses)
            {
                if (item.CourseID == course.CourseID)
                {
                    return;
                }
            }

            Courses.Add(course);
        }
    }
}