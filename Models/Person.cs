using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grobble.Models
{
    public class Person
    {

        public static bool MALE = true;
        public static bool FEMALE = false;

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool Gender { get; set; }
        public string DateOfBirth { get; set; }

    }
}