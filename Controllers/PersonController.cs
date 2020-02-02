using System.Collections.Generic;
using dotnet_test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_test.Controllers
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly PersonService _personService;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
            _personService = new PersonService();
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personService.GetAllPeople();
        }

        // TODO: write a method to return a string list 
        // where the string is the first and last name
        // sorted by first name (a-z)
        // EXAMPLE: [ "Ash Ketchum", "Lieutenant Surge", ... ]
    }
}