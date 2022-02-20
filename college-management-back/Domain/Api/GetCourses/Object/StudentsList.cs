using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class StudentsList
    {
        public Dictionary<int, StudentItem> Students { get; set; }

        public StudentsList()
        {
            Students = new Dictionary<int, StudentItem>();
        }

        public void Add(int identifier, StudentItem student)
        {
            if (Students.ContainsKey(identifier))
            {
                return;
            }

            Students.Add(identifier, student);
        }
    }
}