using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.BL;
using task6.UI;
using task6.DL;

namespace task6.UI
{
    class admin_menu
    {
        public static void Admin_menu(ref int option)
        {
            Console.WriteLine("1.Add product: ");
            Console.WriteLine("2.View All products: ");
            Console.WriteLine("3.Find product with the highest price: ");
            Console.WriteLine("4.view sales tax of all products: ");
            Console.WriteLine("5.Products to be ordered: ");
            Console.WriteLine("0.Exit: ");
            option = int.Parse(Console.ReadLine());
        }
        public static void product_menu(ref string name, ref string category, ref int price, ref int quantity, ref int min_quantity)
        {
            Console.WriteLine("Enter the name of product: "); 
            name=Console.ReadLine();
            Console.WriteLine("Enter the category: ");
            category = Console.ReadLine();
            Console.WriteLine("Enter the price: ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity: ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum quantity: ");
            min_quantity = int.Parse(Console.ReadLine());
        }
        public static void list_of_products()
        {
            foreach (product data in products_.products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", data.name, data.category, data.price, data.quantity, data.min_quantity);
            }
            Console.ReadKey();
        }
        public static void priciest_product()
        {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", products_.products[0].name, products_.products[0].category, products_.products[0].price, products_.products[0].quantity, products_.products[0].min_quantity);
            Console.ReadKey();
        }
        public static void print_tax()
        {
            foreach(product data in products_.products)
            {
                Console.WriteLine("{0}\t{1}\t{2}",data.name, data.category,data.tax);

            }
            Console.ReadKey();
        }
        public static void print(product data)
        {
            Console.WriteLine("{0}\t{1}", data.name, data.quantity);
            Console.ReadKey();
        }
        public static void name(ref string name)
        {
            Console.WriteLine("Enter product name:");
            name = Console.ReadLine();
        }
        public static void order(ref int quantity)
        {
            Console.WriteLine("Enter the amount to be ordered:");
            int q =int.Parse( Console.ReadLine());
            quantity += q;
        }
    }
}
