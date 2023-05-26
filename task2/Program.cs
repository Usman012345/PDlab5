using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.testclass;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int roll_no;
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the roll_no");
                roll_no = int.Parse(Console.ReadLine());
                sort obj = new sort(name, roll_no);
                sort.s.Add(obj);
            }
            Console.WriteLine("unsorted");
            foreach(sort data in sort.s)
            {
                Console.WriteLine("{0} \t {1}", data.name, data.roll_no);
            }
           sort.s= sort.s.OrderBy(o => o.roll_no).ToList();
            Console.WriteLine("sorted");

            foreach (sort data in sort.s)
            {
                Console.WriteLine("{0} \t {1}", data.name, data.roll_no);
            }
            Console.ReadKey();
        }
    }
}
