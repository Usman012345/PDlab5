using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.BL;

namespace task5.UI
{
    class Line_
    {
        public static void clear_screen()
        {
            Console.Clear();
        }
        public static void line(Line line_)
        {
            Console.WriteLine("Enter X1: ");
           line_.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            line_.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            line_.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            line_.b = int.Parse(Console.ReadLine());
        }
        public static void update_begin_point(Line line_)
        {
            Console.WriteLine("Enter new corrdinates for X1: ");
            line_.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new coordinate Y1: ");
            line_.y = int.Parse(Console.ReadLine());

        }
        public static void update_end_point(Line line_)
        {
            Console.WriteLine("Enter new corrdinates for X2: ");
            line_.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new coordinate Y2: ");
            line_.b = int.Parse(Console.ReadLine());

        }
        public static void show_begin_point(Line line_)
        {
            Console.WriteLine("The begin point is x-coordinate{0}  y-coordinate{1} ",line_.x,line_.y);
            Console.ReadKey();        
        }
        public static void show_end_point(Line line_)
        {
            Console.WriteLine("The end point is x-coordinate{0}  y-coordinate{1} ", line_.a, line_.b);
            Console.ReadKey();
        }
        public static void print(double length)
        {
            Console.WriteLine("The length/gradient/distance of the line is {0}", length);
            Console.ReadKey();
        }
       
    }
}
