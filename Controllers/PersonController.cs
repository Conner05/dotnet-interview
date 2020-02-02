using System.Collections.Generic;
using System.Linq;
using dotnet_test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
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
        [HttpGet]
        [Route("names")]
        public IEnumerable<string> GetNames()
        {
            var people = _personService.GetAllPeople();
            return people.OrderBy(p => p.FirstName).Select(p => $"{p.FirstName} {p.LastName}");
        }
    }
}