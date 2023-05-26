using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;
using task4.DL;

namespace task4.UI
{
    class Print_Meritlist
    {
      public static void  print_meritlist(Student data)
        {
            Console.WriteLine("{0}         {1}", data.name, data.merit);
        }
    }
}
