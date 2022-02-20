using college_management_back.Domain.Person;
using college_management_back.Models;

namespace college_management_back.Domain.Api.GetSubjects
{
    public class TeachersListItem
    {

        public int TeacherID { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }

        public static TeachersListItem FromDatabaseTeacher(Teacher teacher)
        {
            return new TeachersListItem
            {
                TeacherID = teacher.TeacherID,
                Salary = teacher.Salary,
                Name = teacher.Name,
                Birthday = teacher.Birthday.ToString(),
            };
        }
    }
}