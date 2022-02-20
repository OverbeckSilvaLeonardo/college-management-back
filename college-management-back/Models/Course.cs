using System.Collections.Generic;

namespace college_management_back.Models
{
    public class Course
    {
        public Course()
        {

        }
        public int CourseID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}