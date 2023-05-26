using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.UI;
using task4.Student_;
using task4.DL;

namespace task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            degree_.Read_data();
            student_.read_data();
            int option,option_Admin,option_student;
            option =main_menu. Menu();
            while (true)
            {
                if (option == 1)
                {

                    option_Admin = admin_menu.Admin();
                    if(option_Admin==0)
                    {
                        option = main_menu.Menu();
                    }
                    Admin_Platform(option_Admin);

                }
                if (option == 2)
                {
                    option_student = Student_menu.student_menu();
                    if (option_student == 0)
                    {
                        option = main_menu.Menu();
                    }
                    Student_Platform(option_student);
                }
                if(option==0)

                {
                    degree_.Store_data();
                    student_.read_data();
                    Environment.Exit(0);
                }

            }

        }
        static int Admin_Platform(int option_Admin)
        {
            if(option_Admin==1)
            {
              degree_.programList.Add(Degree_program());
            }
            if(option_Admin==2)
            {
                Generate_merit();
            }
            if(option_Admin==3)
            {
               subject_. subjects.Add(Add_subject());
                
            }
            if(option_Admin==4)
            {
                print_registered_students();   
            }
            if(option_Admin==5)
            {
                view_specific_program_students();
            }
            if(option_Admin==6)
            {
                calculatefee();
            }
            if(option_Admin==0)
            {
                return 0;
            }
            return 0;
        }
        static DegreeProgram Degree_program()
        {
            string degreeName="";
            float degreeDuration=0F;
            int seats=0;
            int totalcredithours = 0;
           admin_menu.degree_program(ref degreeName,ref degreeDuration,ref seats,ref totalcredithours);
            DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats, totalcredithours);
            degree_.programList.Add(d);
            return d;
        }
        static int Generate_merit()
        {
            string degreename="";
            Enter_program.enter_program(ref degreename);
            int seats=0,y=0;
            for(;y< degree_.programList.Count;y++)
            {
                if(degreename== degree_.programList[y].degreeName)
                {
                    break;
                }
            }
            Student s = new Student();
            student_.meritlist = s.calculateMerit(student_.studentList, student_.meritlist);
            //List<Student> temp =student_. studentList;
            foreach (Student data in student_.studentList)
            {
              
                if (degreename == data.preferences[0])
                {
                  
                    Print_Meritlist.print_meritlist(data);
                      /*  data.registered_degree = degreename;*/
                        if (seats < degree_.programList[y].seats)
                        {
                            
                            student_.registered_students.Add(data);
                            seats++;
                        }
                        else
                        {
                            break;
                        }
                    
                }
            }
            foreach(Student data in student_.registered_students)
            {
                data.registered_degree = degreename;
            }
            readkey.Readkey();
            return 0;
        }
        static void print_registered_students()
        {
            for (int x = 0; x < student_.registered_students.Count; x++)
            {
                Print_Student_list.print_student_list(x);
            }
            readkey.Readkey();
        }
        static void view_specific_program_students()
        {
            string program="";
           Enter_program. enter_program(ref program);
            foreach (Student data in student_. studentList)
            {
                if (program == data.registered_degree)
                {
                    Print_Student_list. students_of_program(data);
                }
            }
            readkey.Readkey();
        }
        static void calculatefee()
        {
            float fee=0F;
            Student s = new Student();
            foreach (Student data in student_. studentList)
            {
                foreach (Student data_ in student_.registered_students)
                {
                    if (data.name ==data_.name)
                    {
                      fee=  s.calculateFee(data.name, subject_.subjects);
                        break;
                    }
                }
                Print_Student_list.fees(data,fee);
            }
            readkey.Readkey();

        }
        static Subject Add_subject()
        {
         string code="";
         string type="";
         int creditHours = 0;
         int subjectFees=0;
            bool checkcredithours = false;
            string degree="";
            Enter_program.enter_program(ref degree);
                foreach (DegreeProgram data in degree_.programList)
                {
                if (degree == data.degreeName && data.totalcredithours <= 20)
                    {
                    Add_subject_.subject_data(ref code,ref type,ref creditHours,ref subjectFees,ref checkcredithours,data);
                  
                        break;
                    }
                else
                {
                    Add_subject_.threshold();
                    readkey.Readkey();
                }
                }
            Subject s = new Subject(degree,code,type,creditHours,subjectFees);
            return s;
        }
        
       static int Student_Platform(int option_student)
        {
            Console.Clear();

            if (option_student==1)
            {
                student_.studentList.Add( register());
            }
            if(option_student==2)
            {
                string name="";
              student_ s= ( register_subjects(ref name));
            }
            return 0;
        }
        static Student register()
        {
            int no=0;
             string name="";
             int age=0;
            double fscMarks=0;
            double ecatMarks=0;
             List<string> preferences = new List<string>();
            Student_menu.student_data(ref name, ref age, ref no, ref fscMarks, ref ecatMarks,preferences);
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static student_ register_subjects(ref string name)
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            student_ s = new student_();
            string code="";
            int no=0;
            string degree="";
            Enter_program.enter_program(ref degree);
           Register_subjects.offered_subjects();
            foreach (Subject data in subject_.subjects)
            {
                if(data.degree==degree)
                {
                   Register_subjects. offered_subjects(data);
                }
            }
            Register_subjects.no_of_subjects(ref no);
            for(int x=0;x<no;x++)
            {
                Register_subjects.Add_Subject(ref code);
                foreach(Subject data in subject_.subjects)
                {
                    foreach (Student dta in student_.registered_students)
                    {
                        if (name == dta.name)
                        {
                            if (data.code == code)
                            {
                                dta.regestered_subjects.Add(data);
                            }
                        }
                    }
                }
            }
            return s;
        }

    }
}
