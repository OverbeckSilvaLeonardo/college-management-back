using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace college_management_back.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public JsonResult<List<object>> Get()
        {
            List<object> resultado = new List<object>();
            resultado.Add(new
            {
                Nome = "Linha de Código",
                URL = "www.linhadecodigo.com.br"
            });
            resultado.Add(new
            {
                Nome = "DevMedia",
                URL = "www.devmedia.com.br"
            });
            resultado.Add(new
            {
                Nome = "Mr. Bool",
                URL = "www.mrbool.com.br"
            });

            return Json(resultado);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
