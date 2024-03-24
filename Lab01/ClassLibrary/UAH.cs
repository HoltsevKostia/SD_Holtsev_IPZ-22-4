using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UAH : Money
    {
        public UAH(int left, int right) : base(left, right)
        {
        }
        public override string ToCurrency()
        {
            return $"{Left} грн. {Right:00} коп.";
        }
    }
}
