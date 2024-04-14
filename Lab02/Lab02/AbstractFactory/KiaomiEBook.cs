using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class KiaomiEBook : EBook
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Kiaomi EBook");
        }
    }
}
