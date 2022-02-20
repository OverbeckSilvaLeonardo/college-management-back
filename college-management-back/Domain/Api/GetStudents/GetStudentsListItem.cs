using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetStudents
{
    public class GetStudentsListItem
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public GradesList Grades { get; set; }
    }
}