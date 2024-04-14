using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class DeviceFactory
    {
        public abstract Laptop CreateLaptop();
        public abstract Netbook CreateNetbook();
        public abstract EBook CreateEBook();
        public abstract Smartphone CreateSmartphone();
    }
}
