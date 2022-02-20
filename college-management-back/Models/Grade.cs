using System.ComponentModel.DataAnnotations.Schema;

namespace college_management_back.Models
{
    public class Grade
    {
        public Grade()
        {
        }

        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public decimal Value { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}