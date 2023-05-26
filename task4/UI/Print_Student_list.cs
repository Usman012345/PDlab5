using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.DL;
using task4.Student_;

namespace task4.UI
{
    class Print_Student_list
    {
      public static void print_student_list(int x)
        {
            Console.WriteLine(student_.registered_students[x].name + "\t" + student_.registered_students[x].registered_degree + "\t" + student_.registered_students[x].age);
        }
        public static void students_of_program(Student data)
        {
            Console.WriteLine(data.name);
        }
        public static void fees(Student data,float fee)
        {
            Console.WriteLine(data.name + "    " + fee);
        }
    }
}
