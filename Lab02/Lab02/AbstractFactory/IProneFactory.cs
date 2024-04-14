using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IProneFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public override Netbook CreateNetbook()
        {
            return new IProneNetbook();
        }

        public override EBook CreateEBook()
        {
            return new IProneEBook();
        }

        public override Smartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}
