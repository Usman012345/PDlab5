using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.DL;
using task6.UI;

namespace task6.BL
{
    class product
    {
        public string name;
        public string category;
        public int price;
        public int quantity;
        public int min_quantity;
        public float tax;
        public product(string name,string category,int price,int quantity,int min_quantity)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.quantity = quantity;
            this.min_quantity = min_quantity;
            this.tax = 0F;
        }
        public static void sales_tax()
        {
           foreach(product data in products_.products)
            {
                if(data.category=="grocery")
                {
                    data.tax = (10F / 100F) * data.price;
                }
                else if(data.category=="fruit")
                {
                    data.tax = (5F / 100F) * data.price;
                }
                else
                {
                    data.tax = (15F / 100F) * data.price;
                }
            }
        }
        public static void reorder_products()
        {
            string name="";
            admin_menu.name(ref name);
            bool exists = false;
            foreach (product data in products_.products)
            {
                if (data.name == name)
                {
                    exists = true;
                }
                if (exists == true)
                {
                    admin_menu.order(ref data.quantity);
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
