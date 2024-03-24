using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        public List<Product> Products { get; set; }
        public int Amount { get; internal set; }
        public DateTime LastDeliveryDate { get; internal set; }

        public Warehouse(List<Product> products)
        {
            Products = products;
        }
    }
}
