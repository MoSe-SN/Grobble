using Grobble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grobble.Services
{
    public class PersonService
    {
        #region Data Access Methods

        #endregion

        #region Filter Methods
        public List<Person> FilterPersonByFirstname(string firstname, List<Person> persons)
        {
            var filteredPersons = persons
                .Where(person => person.Firstname == firstname)
                .ToList();

            return filteredPersons;
        }
        public List<Person> FilterPersonByLastname(string lastname, List<Person> persons)
        {
            var filteredPersons = persons
                .Where(person => person.Lastname == lastname)
                .ToList();

            return filteredPersons;
        }
        public List<Person> FilterPersonByGender(bool gender, List<Person> persons)
        {
            var filteredPersons = persons
                .Where(person => person.Gender == gender)
                .ToList();

            return filteredPersons;
        }
        #endregion
    }
}