using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BalaxySmartphone : Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Balaxy Smartphone");
        }
    }
}
