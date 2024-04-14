using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BalaxyFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }

        public override Netbook CreateNetbook()
        {
            return new BalaxyNetbook();
        }

        public override EBook CreateEBook()
        {
            return new BalaxyEBook();
        }

        public override Smartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
}
