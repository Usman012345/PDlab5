using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;
using task4.DL;

namespace task4.Student_
{
    class Student
    {
        public string name;
        public List<Subject> regestered_subjects = new List<Subject>();
        public int age;
        public List<string> preferences = new List<string>();
        public string registered_degree;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public DegreeProgram regDegree;
      public  student_ s = new student_();
        public Student()
        {
        }
        public Student(string name, int age, double fscMarks, double ecatMarks, List<string> preferences)
        {
            
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
           this.preferences=preferences;
        }
        public List<double> calculateMerit(List<Student> studentList,List<double> meritlist)
        {
            
            foreach(Student data in studentList)
            {
                this.merit = ((data.fscMarks / 1100) * 60) + ((data.ecatMarks / 400) * 40);
                meritlist.Add(this.merit);
            }
            double[] array = meritlist.ToArray();
            Student[] array1 = studentList.ToArray();
            Array.Sort(array, array1);
            meritlist.Clear();
            studentList.Clear();
            meritlist.AddRange(array);
            studentList.AddRange(array1);
            meritlist.Reverse();
            studentList.Reverse();
            foreach(Student dta in studentList)
            {
                foreach(double data in meritlist)
                {
                    dta.merit = data;
                }
            }
            return meritlist;
            
        }
        public int getCreditHours()
        {
            return 0;
        }
        public float calculateFee(string name,List<Subject> subjects)
        {
            float fee=0F;
            int y = 0;
            do
            {
                for (int x = 0; x < s.regestered_subjects.Count; x++)
                {
                    if (s.regestered_subjects[y] == subjects[x].code)
                    {
                        fee += (subjects[x].subjectFees);
                        y++;
                    }

                }
            }
            while (y <= s.regestered_subjects.Count);
           
            return fee;
        }
       /* public void regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
            }

            else
            {
                // This needs to change
              *//*  Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");*//*

            }
            
        }*/
        
    }
}
