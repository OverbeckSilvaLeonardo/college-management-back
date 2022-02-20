using college_management_back.Domain.Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Api.GetSubjects
{
    public class SubjectsListItem
    {
        public int SubjectID { get; set; }
        public string Description { get; set; }
        public int StudentCount { get; set; }
        public TeachersListItem TeacherInformation { get; set; }
        public StudentsList StudentsList { get; set; }
    }
}