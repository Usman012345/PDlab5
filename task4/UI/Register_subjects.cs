using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;

namespace task4.UI
{
    class Register_subjects
    {
        public static void offered_subjects()
        {
            Console.WriteLine("Offered subjects: ");
        }
        public static void offered_subjects(Subject data)
        {
            Console.WriteLine("{0}    {1}    {2}    {3}", data.code, data.type, data.creditHours, data.subjectFees);
        }
        public static void no_of_subjects(ref int no)
        {
            Console.WriteLine("Enter the no of subjects you want to register: ");
            no = int.Parse(Console.ReadLine());
        }
        public static void Add_Subject(ref string code)
        {
            Console.WriteLine("Enter the subject code: ");
            code = Console.ReadLine();
        }
    }
}
