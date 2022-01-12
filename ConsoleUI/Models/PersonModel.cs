using System;

namespace ConsoleUI.Models
{
    // blueprint
    public class PersonModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int Age { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreated { get; set; }

        private int _age;

        public int Age
        {
            get
            { 
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range");
                }
                
            }
        }

        // public string SocialSecurityNumber { get; set; }

        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set 
            { 
                _ssn = value;
            }
        }

        private string __password;

        public string Password
        {
            set { __password = value; }
        }
        

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel()
        {
            
        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
