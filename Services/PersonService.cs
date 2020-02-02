using System.Collections.Generic;
using dotnet_test.Controllers;

namespace dotnet_test.Services
{
    public class PersonService
    {
        public IEnumerable<Person> GetAllPeople()
        {
            return PeopleData.GetPeople();
        }
    }
}