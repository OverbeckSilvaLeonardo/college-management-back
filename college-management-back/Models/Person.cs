using college_management_back.Domain.Person;
using college_management_back.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Models
{
    public abstract class Person : IPerson
    {
        protected Person()
        {
        }

        public string Name { get; set; }
        public Birthday Birthday { get; set; }
    }
}