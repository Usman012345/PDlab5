using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.UI
{
    class main_menu
    {
       public static int Menu()
        {
            while (true)
            {
                Console.Clear();
                int option;
                Console.WriteLine("1.Admin.");
                Console.WriteLine("2.Student.");
                Console.WriteLine("0.Exit.");
                option = int.Parse(Console.ReadLine());

                return option;
            }
        }
    }
}
