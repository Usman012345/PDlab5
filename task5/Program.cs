using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.BL;
using task5.UI;
namespace task5
{
    class Program
    {
        static Line line_ = new Line();
        static void Main(string[] args)
        {
            while (true)
            {
               Line_. clear_screen();
                int option = main_menu_.Main_menu();

                if (option == 1)
                {
                    Line_.line(line_);

                }

                else if (option == 2)
                {
                    Line_.update_begin_point(line_);
                }
                else if (option == 3)
                {
                    Line_.update_end_point(line_);
                }
                else if (option == 4)
                {
                    Line_.show_begin_point(line_);
                }
                else if (option == 5)
                {
                    Line_.show_end_point(line_);
                }
                else if (option == 6)
                {
                    double length = line_.getlenght();
                    Line_.print(length);
                }
                else if (option == 7)
                {
                    double gradient = line_.getgradient();
                    Line_.print(gradient);
                }
                else if (option == 8)
                {
                    double distance = line_.Distance_of_beginpoint_form_orgin();
                    Line_.print(distance);

                }
                else if (option == 9)
                {
                    double distance = line_.Distance_of_endpoint_form_orgin();
                    Line_.print(distance);

                }
                else if (option == 0)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
