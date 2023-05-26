using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task4.Student_;
using System.IO;
using System.Threading.Tasks;

namespace task4.DL
{
    class student_
    { 
        public static List<Student> studentList = new List<Student>();
       public static List<double> meritlist = new List<double>();
       public static List<Student> registered_students = new List<Student>();
        public static void store_data()
        {
            StreamWriter data = new StreamWriter("E:\\D\\PDlab5\\task4\\Student_data.txt", true);
            foreach (Student data_ in registered_students)
            {
                data.Write(data_.name+","+data_.age+","+data_.registered_degree+","+data_.merit);
            }
            data.Flush();
            data.Close();
        } 
        public static void read_data()
        {
            string line;
            string[] line_;
            StreamReader dta=new StreamReader("E:\\D\\PDlab5\\task4\\Student_data.txt", true);
            foreach (Student data_ in registered_students)
            {
                line = dta.ReadLine();
                line_ = line.Split(',');
                data_.name = line_[0];
                data_.age =int.Parse(line_[1]);
                data_.registered_degree = line_[2];
                data_.merit = double.Parse(line_[3]);
            }

        }
        
    }
}
