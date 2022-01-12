using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Models;

namespace ConsoleUI
{
    public static class ProcessPerson
    {
        public static void GreatPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            person.HasBeenGreated = true;
        }
    }
}
