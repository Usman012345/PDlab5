using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.BL;
using task6.UI;
using task6.DL;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool admin__=true,customer__=true;

            int option=0;
            string role;
            while (true)
            {
               customer_menu.clear();
                role = signin_up.sign_in_up();
                if (role == "Admin")
                {
                    do
                    {
                        customer_menu.clear();
                        admin_menu.Admin_menu(ref option);
                        if (option == 0)
                        {
                            admin__ = false;
                        }
                        admin_platform(option);
                    }
                    while (admin__ == true);
                }
                if (role == "customer")
                {
                    do
                    {
                        customer_menu.clear();
                        customer_menu.customer_menu_(ref option);
                        if (option == 0)
                        {
                            customer__ = false;
                        }
                        customer_platform(option);
                    }
                    while (customer__ == true);
                }
            }

        }
        static int admin_platform(int option)
        {
            
            string name="";
            string category="";
            int price=0;
            int quantity=0;
            int min_quantity=0;
            if (option==1)
            {
              admin_menu.product_menu(ref name,ref category,ref price,ref quantity,ref min_quantity);
                product p = new product(name,category,price,quantity,min_quantity);
                products_.products.Add(p);
            }
            else if(option==2)
            {
                admin_menu.list_of_products();
            }
            else if(option==3)
            {
                products_.products=products_.products.OrderBy(o => o.price).ToList();
                products_.products.Reverse();
                admin_menu.priciest_product();
            }
            else if(option==4)
            {
               product.sales_tax();
                admin_menu.print_tax();
            }
            else if(option==5)
            {
                foreach(product data in products_.products)
                {
                    if(data.quantity<data.min_quantity)
                    {
                        admin_menu.print(data);

                    }
                }
               product.reorder_products();
            }
            else if(option==0)
            {
                return 0;
            }
            return 0;
        }
        static int customer_platform(int option)
        {

            if(option==1)
            {
                admin_menu.list_of_products();
            }
            else if(option==2)
            {
                string name = "";
                int quantity = 0;
                customer_menu.buy_products(ref name,ref quantity);
                customer c = new customer(name,quantity);
                customer_.bought_products.Add(c);
            }
            else if(option==3)
            {
               customer_menu.generete_invoice();
            }
            else if(option==0)
            {
                return 0;
            }
            return 0;
        }
    }
}
