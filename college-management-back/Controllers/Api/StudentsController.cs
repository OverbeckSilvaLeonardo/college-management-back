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
using college_management_back.Domain.Api.GetStudents;
using college_management_back.Models;

namespace college_management_back.Controllers.Api
{
    public class StudentsController : ApiController
    {
        private UniversityContext db = new UniversityContext();

        // GET: api/Students
        public JsonResult<GetStudentsList> GetStudents()
        {
            List<Student> students = db.Students.ToList();

            return Json(GetStudentsList.FromStudentsList(students));
        }
    }
}