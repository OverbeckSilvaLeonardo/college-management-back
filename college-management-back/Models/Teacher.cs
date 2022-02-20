using college_management_back.Models.Interface;

namespace college_management_back.Models
{
    public class Teacher : Person, IPerson
    {
        public Teacher()
        {
        }

        public int TeacherID { get; set; }
        public decimal Salary { get; set; }
    }
}