namespace college_management_back.Domain.Api
{
    public class SubjectApiDTO
    {
        public int SubjectID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string Description { get; set; }
    }
}