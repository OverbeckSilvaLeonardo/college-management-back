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
                List<ExpandoObject> subjectsDto = new List<ExpandoObject>();

                course.Subjects.ToList().ForEach(sub => {
                    dynamic subObj = new ExpandoObject();
                    subObj.SubjectID = sub.SubjectID;
                    subObj.CourseID = sub.CourseID;
                    subObj.TeacherID = sub.TeacherID;
                    subObj.Description = sub.Description;

                    List<ExpandoObject> studentsDto = new List<ExpandoObject>();

                    sub.Students.ToList().ForEach(stu => {
                        dynamic stuObj = new ExpandoObject();
                        stuObj.Name = stu.Name;                   
                        stuObj.Grade = stu.Grades
                            .Where(g => g.StudentID == stu.StudentID && g.SubjectID == sub.SubjectID)
                            .FirstOrDefault()
                            .Value;

                        studentsDto.Add(stuObj);
                    });

                    subObj.Students = studentsDto;


                    subjectsDto.Add(subObj);
                });

                dynamic courseObj = new ExpandoObject();
                courseObj.CourseID = course.CourseID;
                courseObj.Description = course.Description;
                courseObj.Subjects = subjectsDto;

                result.Add(courseObj);
            });

            return result;
        }
    }
}