using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grobble.Models
{
    public class MilitaryPerson : Person
    {
        public int BadgeRegNum { get; set; }
        public string RegistrationNum { get; set; }
    }
}