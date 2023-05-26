using System;
using System.Collections.Generic;
using System.Linq;
using task4.Student_;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4.DL
{
    class degree_
    {
       public static List<DegreeProgram> programList = new List<DegreeProgram>();
        public static void Store_data()
        { 
            StreamWriter data = new StreamWriter("E:\\PD\\PDlab5\\task4\\Degree_data.txt", true);
            foreach(DegreeProgram data_ in programList)
            {
                data.WriteLine(data_.degreeName+","+data_.degreeDuration + ","+ data_.totalcredithours + "," +data_.seats);
            }
        }
        public static void Read_data()
        {
            string line;
            string[] line_;
            StreamReader data = new StreamReader("E:\\PD\\PDlab5\\task4\\Degree_data.txt", true);
            foreach(DegreeProgram data_ in programList)
            {
                line= data.ReadLine();
                line_ = line.Split(',');
                data_.degreeName = line_[0];
                data_.degreeDuration = int.Parse(line_[1]);
                data_.totalcredithours = int.Parse(line_[2]);
                data_.seats = int.Parse(line_[3]);
            }
        }
    }
    
}
