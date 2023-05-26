using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.DL;
using task4.Student_;

namespace task4.UI
{
    class Add_subject_
    {
        public static void subject_data(ref string code, ref string type, ref int creditHours, ref int subjectFees,ref bool checkcredithours,DegreeProgram data)
        {
            Console.WriteLine("Enter the subject code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter type:");
            type = Console.ReadLine();
            Console.WriteLine("Enter the credit hours:");
            creditHours = int.Parse(Console.ReadLine());
            DegreeProgram d = new DegreeProgram();
            checkcredithours = d.calculateCreditHours(creditHours);
            if (checkcredithours == true)
                data.totalcredithours += creditHours;
            if (checkcredithours == false)
            {
                Console.WriteLine("too many credit hours  Remaining credit hours{0}", (20 - data.totalcredithours));
                Console.ReadKey();
            }
            Console.WriteLine("Enter the subject fees:");
            subjectFees = int.Parse(Console.ReadLine());
        }
        public static void threshold()
        {
            Console.WriteLine("You have reached the threshold of credit hours or the program is not registered");
        }
    }
}
