using college_management_back.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class GetCoursesApiResultFormatter
    {
        public static CoursesList FromCourses(List<Course> courses)
        {
            CoursesList result = new CoursesList();

            courses.ForEach(course =>
            {
                var extractedStudents = StudentsList.FromCourse(course);
                var item = new CourseItem { CourseID = course.CourseID, Description = course.Description, StudentsCount = extractedStudents.Count(), StudentsList = extractedStudents };
 
                result.Add(course.CourseID, item);
            });

            return result;
        }
    }
}