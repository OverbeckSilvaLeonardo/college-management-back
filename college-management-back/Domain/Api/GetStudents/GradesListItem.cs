namespace college_management_back.Domain.Api.GetStudents
{
    public class GradesListItem
    {
        public int GradeID { get; set; }
        public int SubjectID { get; set; }
        public string Subject { get; set; }
        public decimal Grade { get; set; }
    }
}