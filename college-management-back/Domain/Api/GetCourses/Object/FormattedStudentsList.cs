using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class FormattedStudentsList
    {
        public Dictionary<int, FormattedStudentItem> Students { get; set; }

        public FormattedStudentsList()
        {
            Students = new Dictionary<int, FormattedStudentItem>();
        }

        public void Add(int identifier, FormattedStudentItem student)
        {
            if (Students.ContainsKey(identifier))
            {
                return;
            }

            Students.Add(identifier, student);
        }
    }
}