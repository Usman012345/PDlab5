using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.UI
{
    class Enter_program
    {
        public static void enter_program(ref string degreename)
        {
            Console.WriteLine("Enter the Program: ");
            degreename = Console.ReadLine();
        }
        
    }
}
