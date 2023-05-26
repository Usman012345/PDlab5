using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using task6.UI;
using task6.DL;
namespace task6.BL
{
    class signin_up
    {
        public static string sign_in_up()
        {
            int count = 0;
            string role__;
            signdata.read_count(ref count);
            int option=0;
            signin_up_.sign_menu(ref option);
            if (option == 1)
            {
                signup(ref count);
            }
            else if (option == 2)
            {
                role__ = signin(ref count);
                return role__;
            }
            else
            {
                Environment.Exit(0);
            }
            return null;
        }
        static string signin(ref int count)
        {
            string Username_="", password_="",role="";
            signin_up_.username_password(ref Username_, ref password_,ref role, "signin");
            bool exists =signdata. readfile(Username_, password_,ref role, count);
            if (exists == true)
            {
                return role;
            }
            else
                signin_up_.valid_invalid("invalid");
            
            return role;
        }
        static void signup(ref int count)
        {
            string Username="", password="",role="";
            signin_up_.username_password(ref Username,ref password,ref role,"signup");
            count++;
           signdata.storedata(Username, password,role,count);
            signin_up_.proceding();
            Thread.Sleep(200);
            signin(ref count);
        }
      
    }
}
