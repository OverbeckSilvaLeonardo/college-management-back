using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Http.Results;
using college_management_back.DAL;
using college_management_back.Domain.Api.GetCourses;
using college_management_back.Models;
using Newtonsoft.Json;

namespace college_management_back.Controllers.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CoursesController : ApiController
    {
        private UniversityContext db = new UniversityContext();

        // GET: api/Courses
        public JsonResult<CoursesList> GetCourses()
        {
            List<Course> courses = db.Courses.ToList();

            return Json(CoursesList.FromCoursesList(courses));
        }
    }
}