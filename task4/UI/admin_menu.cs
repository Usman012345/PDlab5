using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.UI
{
    class admin_menu
    {
       public static int Admin()
        {
            while (true)
            {
                Console.Clear();
                int option;
                Console.WriteLine("1.Add Degree program");
                Console.WriteLine("2.Generate merit");
                Console.WriteLine("3.Add subjects");
                Console.WriteLine("4.View registered students");
                Console.WriteLine("5.View students of a specific program");
                Console.WriteLine("6.Calculate fees of all registered students");
                Console.WriteLine("0.Exit");
                option = int.Parse(Console.ReadLine());
                return option;
            }
        }
        public static void degree_program(ref string degreeName, ref float degreeDuration, ref int seats,ref int totalcredithours)
        {
            Console.WriteLine("Enter the degree name:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree duration");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of seats:");
            seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter total Credit hours:");
            totalcredithours = int.Parse(Console.ReadLine());
        }
    }
}
