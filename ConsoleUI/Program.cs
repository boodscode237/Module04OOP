﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel();


            Console.ReadLine();
        }

        public static void PropertiesMethods()
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Joe";
            // person.LastName = "Quagmire";
            person.Age = 50;
            person.SSN = "142-56-8476";
        
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);
        }

        public static void Instantiation()
        {
            // building a person from the blueprint
             // PersonModel person = new PersonModel();

            List<PersonModel> people = new List<PersonModel>();

            person.firstName = "Joe";
            people.Add(person);

            person = new PersonModel();
            person.firstName = "Quagmire";
            people.Add(person);

            foreach (PersonModel p in people)
            {
                Console.WriteLine(p.firstName);
            }

            people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";
        
        
            do
            {
                Console.Write("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();
        
                Console.Write("What is your last name (or type exit to stop): ");
                lastName = Console.ReadLine();
        
                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");
        
            foreach (PersonModel pe in people)
            {
                ProcessPerson.GreatPerson(pe);
            }
        }

        public static void StaticClasses()
        {
            string firstName = RequestData.GetAString("What is your first name: ");
        
            UserMessages.ApplicationStartMessage(firstName);
        
            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");
        
            double result = CalculateData.AddDouble(x, y);
        
            UserMessages.PrintResultMessage($"The sum of x and y is {result}");
        
        }

    }
}
