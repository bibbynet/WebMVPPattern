using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVPPattern.Models;

namespace WebMVPPattern.Services
{
    public class PersonService : IPersonService
    {
        public IList<Person> GetPersonData()
        {
            var list = new List<Person>()
                {
                    new Person(){Name = "Bibby",Age = 30,Birthday = new DateTime(1981,1,1)},
                    new Person(){Name = "BB",Age = 12,Birthday = new DateTime(1970,10,1)},
                    new Person(){Name = "May",Age = 38,Birthday = new DateTime(1450,10,1)}
                };
            return list;
        }
    }
}