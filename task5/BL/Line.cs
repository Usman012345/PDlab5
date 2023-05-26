using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.UI;

namespace task5.BL
{
    class Line
    {
       public int x;
       public int y;
       public int a;
       public int b;
        public double getlenght()
        {
         double result=   Math.Sqrt(Math.Pow((a - x), 2) + Math.Pow((b - y), 2));
            return result;
        }
        public double getgradient()
        {
            double gradient = (b - y) / (a - x);
            return gradient;
        }
        public double Distance_of_beginpoint_form_orgin()
        {
            double result = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            return result;
        }
        public double Distance_of_endpoint_form_orgin()
        {
            double result = Math.Sqrt(Math.Pow((a - 0), 2) + Math.Pow((b - 0), 2));
            return result;
        }
    }
}

