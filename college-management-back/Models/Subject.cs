using System.Collections.Generic;

namespace college_management_back.Models
{
    public class Subject
    {
        public Subject()
        {
        }

        public int SubjectID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string Description { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}