using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5.UI
{
    class main_menu_
    {
        public static int Main_menu()
        {
            Console.WriteLine("1.make a line:");
            Console.WriteLine("2.Update begin point");
            Console.WriteLine("3.update end point");
            Console.WriteLine("4.Show begin point");
            Console.WriteLine("5.Show end point");
            Console.WriteLine("6.Get the length of the line");
            Console.WriteLine("7.Get the gradient of the line");
            Console.WriteLine("8.Find the distance between begin point from origin");
            Console.WriteLine("9.Find the distance of end point from origin");
            Console.WriteLine("0.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
