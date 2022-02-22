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
        public List<SubjectsListItem> Subjects { get; set; }

        public SubjectsList()
        {
            Subjects = new List<SubjectsListItem>();
        }

        public static SubjectsList FromSubjectsList(List<Subject> subjects)
        {
            SubjectsList result = new SubjectsList();
             
            subjects.ForEach(subject =>
            {
                var studentsList = StudentsList.FromDatabaseStudentsList(subject.Students.ToList());
                var teacher = TeachersListItem.FromDatabaseTeacher(subject.Teacher);
                var item = new SubjectsListItem { SubjectID = subject.SubjectID, Description = subject.Description, StudentCount = studentsList.Count(), StudentsList = studentsList, TeacherInformation = teacher };

                result.Add(item);
            });

            return result;
        }

        private void Add(SubjectsListItem subject)
        {
            foreach (var item in Subjects)
            {
                if (item.SubjectID == subject.SubjectID)
                {
                    return;
                }
            }

            Subjects.Add(subject);
        }
    }
}