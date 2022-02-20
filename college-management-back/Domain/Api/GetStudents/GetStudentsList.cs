using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using college_management_back.Models;

namespace college_management_back.Domain.Api.GetStudents
{
    public class GetStudentsList
    {
        public Dictionary<int, GetStudentsListItem> Students { get; set; }

        public GetStudentsList()
        {
            Students = new Dictionary<int, GetStudentsListItem>();
        }

        // List the students and their respective grades of the subject
        public static GetStudentsList FromStudentsList(List<Student> students)
        {
            GetStudentsList result = new GetStudentsList();

            students.ForEach(student => {
                var gradesList = GradesList.FromDatabaseGradesList(student.Grades.ToList());
                var item = new GetStudentsListItem { StudentID = student.StudentID, StudentName = student.Name, Grades = gradesList };

                result.Add(student.StudentID, item);
            });

            return result;
        }

        public void Add(int identifier, GetStudentsListItem student)
        {
            if (Students.ContainsKey(identifier))
            {
                return;
            }

            Students.Add(identifier, student);
        }
    }
}