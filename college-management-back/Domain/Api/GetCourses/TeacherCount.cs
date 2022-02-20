using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses
{
    public class TeacherCount
    {
        public int Count { get; set; }

        public static TeacherCount FromSubjectsList(List<Subject> subjects)
        {
            var Teachers = new List<int>();

            foreach (var subject in subjects)
            {
                if (Teachers.Contains(subject.TeacherID))
                {
                    continue;
                }

                Teachers.Add(subject.TeacherID);
            }

            return new TeacherCount { Count = Teachers.Count() };
        }
    }
}