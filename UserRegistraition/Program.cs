using System;
using UserRegistraition;

namespace UserRegistration
{

    public class Program
    {
        public static void Main(String[] args)
        {
            User user = new User();

            bool n = true;
            while(n)
            {
                Console.WriteLine("Choose option 1. Firstname 2.Last Name 3.Email 4. mobile no 5.password");
                int option = Int32.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1: user.ValidFirstName(); break;
                    case 2: user.ValidLastName(); break;
                    case 3 : user.ValidEmail(); break;
                    case 4 : user.ValidPhone(); break;
                    case 5: user.ValidPassword(); break;
                    default: n =  false;
                        Console.WriteLine("Enter valid option"); break;
                }
            }

            //user.ValidFirstName();
            //user.ValidLastName();
            //user.ValidEmail();
            user.ValidPhone();
        }
    }
}