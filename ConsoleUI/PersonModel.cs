﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // blueprint
    public class PersonModel
    {
        // public string firstName;
        // public string lastName;
        // public string emailAddress;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreated { get; set; }
    }
}
