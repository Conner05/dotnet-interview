using System.Collections.Generic;
using dotnet_test.Controllers;

namespace dotnet_test
{
    public static class PeopleData
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person() { FirstName = "Ash", LastName = "Ketchum", Age = 10, Gender = "Male" },
                    new Person() { FirstName = "Professor", LastName = "Oak", Age = 50, Gender = "Male" },
                    new Person() { FirstName = "Mrs.", LastName = "Ketchum", Age = 35, Gender = "Female" },
                    new Person() { FirstName = "Misty", LastName = "Upham", Age = 13, Gender = "Female" },
                    new Person() { FirstName = "Nurse", LastName = "Joy", Age = 28, Gender = "Female" },
                    new Person() { FirstName = "Officer", LastName = "Jenny", Age = 30, Gender = "Female" },
                    new Person() { FirstName = "Lieutenant", LastName = "Surge", Age = 40, Gender = "Male" },
            };
        }
    }
}