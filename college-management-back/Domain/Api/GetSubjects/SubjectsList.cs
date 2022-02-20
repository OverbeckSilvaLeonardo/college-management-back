using college_management_back.Domain.Api.Common;
using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetSubjects
{
    public class SubjectsList
    {
        public Dictionary<int, SubjectsListItem> Subjects { get; set; }

        public SubjectsList()
        {
            Subjects = new Dictionary<int, SubjectsListItem>();
        }

        public static SubjectsList FromSubjectsList(List<Subject> subjects)
        {
            SubjectsList result = new SubjectsList();

            subjects.ForEach(subject =>
            {
                var studentsList = StudentsList.FromDatabaseStudentsList(subject.Students.ToList());
                var teacher = TeachersListItem.FromDatabaseTeacher(subject.Teacher);
                var item = new SubjectsListItem { SubjectID = subject.SubjectID, Description = subject.Description, StudentCount = studentsList.Count(), StudentsList = studentsList, TeacherInformation = teacher };

                result.Add(subject.SubjectID, item);
            });

            return result;
        }

        public void Add(int identifier, SubjectsListItem course)
        {
            if (Subjects.ContainsKey(identifier))
            {
                return;
            }

            Subjects.Add(identifier, course);
        }
    }
}