using college_management_back.Domain.Person;
using System;

namespace college_management_back.Models.Interface
{
    public interface IPerson
    {
        string Name { get; set; }
        Birthday Birthday { get; set; }
    }
}