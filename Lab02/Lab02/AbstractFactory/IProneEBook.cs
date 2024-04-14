using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IProneEBook : EBook
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("IProne EBook");
        }
    }
}
