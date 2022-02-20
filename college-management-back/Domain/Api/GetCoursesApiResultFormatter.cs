using college_management_back.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace college_management_back.Domain.Api
{
    public class GetCoursesApiResultFormatter
    {
        public static List<ExpandoObject> FromCourses(List<Course> courses)
        {
            List<ExpandoObject> result = new List<ExpandoObject>();

            courses.ForEach(course =>
            {
                Dictionary<int, ExpandoObject> studentsDto = new Dictionary<int, ExpandoObject>();
                course.Subjects.ToList().ForEach(sub => {

                    foreach (var stu in sub.Students.ToList())
                    {
                        if (studentsDto.ContainsKey(stu.StudentID))
                        {
                            continue;
                        }

                        dynamic stuObj = new ExpandoObject();
                        stuObj.Name = stu.Name;

                        stuObj.AvgGrade = stu.Grades.Average(g => g.Value);
                        studentsDto.Add(stu.StudentID, stuObj);
                    }
                });

                dynamic courseObj = new ExpandoObject();
                courseObj.CourseId = course.CourseID;
                courseObj.Description = course.Description;
                courseObj.Students = studentsDto;

                result.Add(courseObj);
            });

            return result;
        }
    }
}