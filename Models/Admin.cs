using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grobble.Models
{
    public class Admin : MilitaryPerson
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CamAccess { get; set; }
        public bool LogAccess { get; set; }
        public bool ModelAccess { get; set; }
        public bool DbAccess { get; set; }
    }
}