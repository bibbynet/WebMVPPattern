using System.Collections.Generic;
using WebMVPPattern.Models;

namespace WebMVPPattern.Services
{
    public interface IPersonService
    {
        IList<Person> GetPersonData();
    }
}