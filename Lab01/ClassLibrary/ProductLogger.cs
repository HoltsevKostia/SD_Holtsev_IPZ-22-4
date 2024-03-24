using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductLogger : Product
    {
        public List<string> ProductsLogs { get; private set; }
        public ProductLogger(Money price, string name, string description) : base(price, name, description)
        {
        }
        public void PriceDecreaserLogger(double price)
        {
            PriceDecreaser(price);
            ProductsLogs.Add(DateTime.Now.ToString() + "; Нова ціна: " + price);
        }
    }
}
