using System;
using System.Collections.Generic;
using college_management_back.Models;

namespace college_management_back.Domain.Api.GetStudents
{
    public class GradesList
    {
        public Dictionary<int, GradesListItem> Grades { get; set; }

        public GradesList()
        {
            Grades = new Dictionary<int, GradesListItem>();
        }

        public static GradesList FromDatabaseGradesList(List<Grade> grades)
        {
            var result = new GradesList();

            foreach (var grade in grades)
            {
                var item = new GradesListItem { Grade = grade.Value, Subject = grade.Subject.Description, SubjectID = grade.SubjectID };
                result.Add(grade.GradeID, item);
            }

            return result;

        }

        public void Add(int identifier, GradesListItem grade)
        {
            if (Grades.ContainsKey(identifier))
            {
                return;
            }

            Grades.Add(identifier, grade);
        }
    }
}