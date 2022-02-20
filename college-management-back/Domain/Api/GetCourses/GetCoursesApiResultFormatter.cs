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
                var extractedStudents = ExtractStudentsAndAverageGradesFromCourse(course);
                var item = new CourseItem { CourseID = course.CourseID, Description = course.Description, StudentsList = extractedStudents };
 
                result.Add(course.CourseID, item);
            });

            return result;
        }

        private static StudentsList ExtractStudentsAndAverageGradesFromCourse(Course course)
        {
            StudentsList studentsList = new StudentsList();
            course.Subjects.ToList().ForEach(sub =>
            {
                foreach (var stu in sub.Students.ToList())
                {
                    var item = new StudentItem { Name = stu.Name, AvgGrade = stu.Grades.Average(g => g.Value) };
                    studentsList.Add(stu.StudentID, item);
                }
            });

            return studentsList;
        }
    }
}