using college_management_back.Domain.Person;
using college_management_back.Models.Interface;

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