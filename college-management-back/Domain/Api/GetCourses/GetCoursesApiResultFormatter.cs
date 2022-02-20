using college_management_back.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class GetCoursesApiResultFormatter
    {
        public static FormattedCoursesList FromCourses(List<Course> courses)
        {
            FormattedCoursesList result = new FormattedCoursesList();

            courses.ForEach(course =>
            {
                var extractedStudents = ExtractStudentsAndAverageGradesFromCourse(course);
                var item = new FormattedCourseItem { CourseID = course.CourseID, Description = course.Description, StudentsList = extractedStudents };
 
                result.Add(course.CourseID, item);
            });

            return result;
        }

        private static FormattedStudentsList ExtractStudentsAndAverageGradesFromCourse(Course course)
        {
            FormattedStudentsList studentsList = new FormattedStudentsList();
            course.Subjects.ToList().ForEach(sub =>
            {
                foreach (var stu in sub.Students.ToList())
                {
                    var item = new FormattedStudentItem { Name = stu.Name, AvgGrade = stu.Grades.Average(g => g.Value) };
                    studentsList.Add(stu.StudentID, item);
                }
            });

            return studentsList;
        }
    }
}