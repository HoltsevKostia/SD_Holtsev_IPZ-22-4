using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class KiaomiFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public override Netbook CreateNetbook()
        {
            return new KiaomiNetbook();
        }

        public override EBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public override Smartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
