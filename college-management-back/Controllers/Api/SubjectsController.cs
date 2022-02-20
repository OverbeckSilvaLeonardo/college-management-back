using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using college_management_back.DAL;
using college_management_back.Domain.Api.GetSubjects;
using college_management_back.Models;

namespace college_management_back.Controllers.Api
{
    public class SubjectsController : ApiController
    {
        private UniversityContext db = new UniversityContext();

        // GET: api/Subjects
        public JsonResult<SubjectsList> GetSubjects()
        {
            List<Subject> subjects = db.Subjects.ToList();

            return Json(SubjectsList.FromSubjectsList(subjects));
        }
    }
}