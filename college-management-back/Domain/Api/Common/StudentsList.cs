using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.Common
{
    public class StudentsList
    {
        public Dictionary<int, StudentsListItem> Students { get; set; }

        public StudentsList()
        {
            Students = new Dictionary<int, StudentsListItem>();
        }

        public static StudentsList FromDatabaseSubjectsList(List<Subject> subjects)
        {
            var studentsList = new StudentsList();

            subjects.ForEach(sub =>
            {
                foreach (var student in sub.Students.ToList())
                {
                    studentsList.Add(student.StudentID, StudentsListItem.FromDatabaseStudent(student));
                }
            });

            return studentsList;
        }

        public static StudentsList FromDatabaseStudentsList(List<Student> students)
        {
            var studentsList = new StudentsList();

            foreach (var student in students)
            {
                studentsList.Add(student.StudentID, StudentsListItem.FromDatabaseStudent(student));
            }

            return studentsList;
        }

        public void Add(int identifier, StudentsListItem student)
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