using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.Domain.Person
{
    public class Birthday
    {
        public Birthday(DateTime date)
        {
            Date = date;
        }

        public DateTime Date { get; set; }
    }
}