using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses
{
    public class StudentsList
    {
        public Dictionary<int, StudentItem> Students { get; set; }

        public StudentsList()
        {
            Students = new Dictionary<int, StudentItem>();
        }

        public static StudentsList FromSubjectsList(List<Subject> subjects)
        {
            var studentsList = new StudentsList();

            subjects.ForEach(sub =>
            {
                foreach (var stu in sub.Students.ToList())
                {
                    var item = new StudentItem { Name = stu.Name, AverageGrade = stu.Grades.Average(g => g.Value) };
                    studentsList.Add(stu.StudentID, item);
                }
            });

            return studentsList;
        }

        public void Add(int identifier, StudentItem student)
        {
            if (Students.ContainsKey(identifier))
            {
                return;
            }

            Students.Add(identifier, student);
        }

        public int Count()
        {
            return Students.Count();
        }
    }
}