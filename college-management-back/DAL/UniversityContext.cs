using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace college_management_back.DAL
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {
        }

        public DbSet<Course> Courses{ get; set; }
        public DbSet<Subject> Subjects{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Grade> Grades{ get; set; }
    }
}