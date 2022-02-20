using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses
{
    public class CoursesList
    {
        public Dictionary<int, CourseItem> Courses { get; set; }

        public CoursesList()
        {
            Courses = new Dictionary<int, CourseItem>();
        }

        public static CoursesList FromCoursesList(List<Course> courses)
        {
            CoursesList result = new CoursesList();

            courses.ForEach(course =>
            {
                var studentsList = StudentsList.FromSubjectsList(course.Subjects.ToList());
                var teacherCount = TeacherCount.FromSubjectsList(course.Subjects.ToList());
                var item = new CourseItem { CourseID = course.CourseID, Description = course.Description, TeacherCount = teacherCount.Count, StudentCount = studentsList.Count(), StudentsList = studentsList };

                result.Add(course.CourseID, item);
            });

            return result;
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