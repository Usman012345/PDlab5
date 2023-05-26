using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6.UI
{
    class signin_up_
    {
      public static void sign_menu(ref int option)
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            Console.WriteLine("0.Exit");
            option = int.Parse(Console.ReadLine());
        }
        public static void username_password(ref string Username, ref string password, ref string role,string type)
        {
            Console.WriteLine("enter your Username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            if(type=="signup")
            {
                Console.WriteLine("Enter the Role: ");
                role = Console.ReadLine();
            }
        }
        public static void valid_invalid(string type)
        {
            if (type == "invalid")
            {
                Console.WriteLine("Invalid input..");
                Console.ReadKey();
            }
        }
        public static void proceding()
        {
            Console.WriteLine("Proceding to sign in menu:..");
        }
    }
}
