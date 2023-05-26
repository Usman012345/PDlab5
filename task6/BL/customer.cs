using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6.BL
{
    class customer
    {
       public string product_name;
       public int quantity;
        public customer(string product,int quantity)
        {
            this.product_name = product;
            this.quantity = quantity;
        }
    }
}
