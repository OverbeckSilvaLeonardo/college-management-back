using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class FormattedStudentItem
    {
        public string Name { get; set; }
        public decimal AvgGrade { get; set; }
    }
}