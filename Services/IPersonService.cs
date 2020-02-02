using System.Collections.Generic;

namespace dotnet_test.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPeople();
    }
}