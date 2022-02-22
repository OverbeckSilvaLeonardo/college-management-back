using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.Common
{
    public class StudentsList
    {
        public List<StudentsListItem> Students { get; set; }

        public StudentsList()
        {
            Students = new List<StudentsListItem>();
        }

        public static StudentsList FromDatabaseSubjectsList(List<Subject> subjects)
        {
            var studentsList = new StudentsList();

            subjects.ForEach(sub =>
            {
                foreach (var student in sub.Students.ToList())
                {
                    studentsList.Add(StudentsListItem.FromDatabaseStudent(student));
                }
            });

            return studentsList;
        }

        public static StudentsList FromDatabaseStudentsList(List<Student> students)
        {
            var studentsList = new StudentsList();

            foreach (var student in students)
            {
                studentsList.Add( StudentsListItem.FromDatabaseStudent(student));
            }

            return studentsList;
        }

        private void Add(StudentsListItem student)
        {
            foreach (var item in Students)
            {
                if (item.StudentID == student.StudentID)
                {
                    return;
                }
            }

            Students.Add(student);
        }

        public int Count()
        {
            return Students.Count();
        }
    }
}