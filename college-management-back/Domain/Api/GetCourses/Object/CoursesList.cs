﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetCourses.Object
{
    public class CoursesList
    {
        public Dictionary<int, CourseItem> CoursesList { get; set; }

        public CoursesList()
        {
            CoursesList = new Dictionary<int, CourseItem>();
        }

        public void Add(int identifier, CourseItem course)
        {
            if (CoursesList.ContainsKey(identifier))
            {
                return;
            }

            CoursesList.Add(identifier, course);
        }
    }
}