﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class KiaomiLaptop : Laptop
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Kiaomi Laptop");
        }
    }
}
