using System;
using UserRegistraition;

namespace UserRegistration
{

    public class Program
    {
        public static void Main(String[] args)
        {
            User user = new User();
            //user.ValidFirstName();
            //user.ValidLastName();
            user.ValidEmail();
        }
    }
}