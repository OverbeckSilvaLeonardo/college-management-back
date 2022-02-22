using System;
using System.Collections.Generic;
using college_management_back.Models;

namespace college_management_back.Domain.Api.GetStudents
{
    public class GradesList
    {
        public List<GradesListItem> Grades { get; set; }

        public GradesList()
        {
            Grades = new List<GradesListItem>();
        }

        public static GradesList FromDatabaseGradesList(List<Grade> grades)
        {
            var result = new GradesList();

            foreach (var grade in grades)
            {
                var item = new GradesListItem { GradeID = grade.GradeID, Grade = grade.Value, Subject = grade.Subject.Description, SubjectID = grade.SubjectID };
                result.Add(item);
            }

            return result;

        }

        private void Add(GradesListItem grade)
        {
            foreach (var item in Grades)
            {
                if (item.GradeID == grade.GradeID)
                {
                    return;
                }
            }

            Grades.Add(grade);
        }
    }
}