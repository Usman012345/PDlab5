using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  task6.BL;
using task6.UI;
using task6.DL;

namespace task6.UI
{
    class customer_menu
    {
        public static void customer_menu_(ref int option)
        {
            Console.WriteLine("1.View all products:");
            Console.WriteLine("2.Buy products: ");
            Console.WriteLine("3.Generate invoice: ");
            Console.WriteLine("0.Exit");
            option = int.Parse(Console.ReadLine());
        }
        public static void clear()
        {
            Console.Clear();
        }
        public static void generete_invoice()
        {
            float bill=0F;
            foreach(customer data in customer_.bought_products)
            {
                foreach(product data_ in products_.products)
                {
                    if(data.product_name==data_.name)
                    {
                        bill += (data_.price + data_.tax)*data.quantity ;
                    }
                }
            }
            Console.WriteLine("The total bill including tax is:{0}",bill);
            Console.ReadLine();
        }
        public static void buy_products(ref string name,ref int quantity)
        {
            bool exists = false;
            Console.WriteLine("Enter the product's name: ");
            name = Console.ReadLine();
            foreach (product data in products_.products)
            {
                if (name ==data.name)
                {
                    exists = true;
                }
                if(exists==true)
                {
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    data.quantity -= quantity;
                    break;
                }
            }
            if(exists==false)
            {
                signin_up_.valid_invalid("invalid");
            }
        }
    }
}
