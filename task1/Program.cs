using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>(){"usman","Ali","hanan" };
            List<float> f = new List<float>() { 1.1F,3.2F,3454F,0,1F};
            foreach(string data in s)
            {
                Console.WriteLine(data);
            }
            foreach(float data in f)
            {
                Console.WriteLine(data);
            }
            s.Sort();
            f.Sort();
            foreach (string data in s)
            {
                Console.WriteLine(data);
            }
            foreach (float data in f)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
