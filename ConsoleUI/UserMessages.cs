using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void ApplicationStartMessage( string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the static app demo app");

            int hoursOfDay = DateTime.Now.Hour;

            if (hoursOfDay < 12)
            {
                Console.WriteLine($"Good Morning {firstName}!");
            }
            else if (hoursOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon {firstName}!");
            }
            else
            {
                Console.WriteLine($"Good Evening {firstName}!");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank You for using our app to calculate for you");
        }
    }
}
