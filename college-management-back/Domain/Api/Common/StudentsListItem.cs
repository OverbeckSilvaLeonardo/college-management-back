using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.Common
{
    public class StudentsListItem
    {
        public string Name { get; set; }
        public decimal AverageGrade { get; set; }

        public static StudentsListItem FromDatabaseStudent(Student student)
        {
            return new StudentsListItem { Name = student.Name, AverageGrade = student.Grades.Average(g => g.Value) };
        }
    }
}