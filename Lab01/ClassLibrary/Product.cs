using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public Money Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        public Product(Money price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }
        //KISS
        public void PriceDecreaser (double price)
        {
            if (Price.Summa() - price > 0)
            {
                double result = Price.Summa() - price;

                Price.Left = (int)result;

                Price.Right = (int)((result - Price.Left) * 100);
            }
            else throw new Exception("Negative price.");
        }
    }
}
