using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;
using task4.DL;

namespace task4.UI
{
    class Student_menu
    {
       public static int student_menu()
        {
            while (true)
            {
                Console.Clear();

                int option;
                Console.WriteLine("1.Register student: ");
                Console.WriteLine("2.Register subjects:");
                Console.WriteLine("0.Exit:");
                option = int.Parse(Console.ReadLine());
                return option;
            }
        }
        public static void student_data(ref string name, ref int age, ref int no, ref double fscMarks, ref double ecatMarks,List<string> preferences)
        {
            Student s = new Student();
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Avaliable programs:");
            for (int x = 1; x < degree_.programList.Count; x++)
            {
                Console.WriteLine(degree_.programList[x].degreeName);
            }
            Console.WriteLine("Enter no of preferences you want to add: ");
            no = int.Parse(Console.ReadLine());
            for (int x = 0; x < no; x++)
            {
                Console.WriteLine("Enter the name of preferences:");
                preferences.Add(Console.ReadLine());
            }
        }
    }
}
