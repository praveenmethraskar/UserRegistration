using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistraition
{
    public class User
    {
        public void ValidFirstName()
        {
            Console.WriteLine("enter First name");
            string data = Console.ReadLine();
            string namepattern = "^[A-Z]{1}[a-zA-Z]{2,}";

            Regex regex = new Regex(namepattern);

            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entered name is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(data); 

        }

        public void ValidLastName()
        {
            Console.WriteLine("enter Last name");
            string data = Console.ReadLine();
            string namepattern = "^[A-Z]{1}[a-zA-Z]{2,}";

            Regex regex = new Regex(namepattern);

            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter last name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entered last name is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(data);

        }
    }
}
