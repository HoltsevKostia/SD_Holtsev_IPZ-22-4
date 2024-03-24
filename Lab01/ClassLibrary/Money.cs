using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Money
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public Money(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public double Summa()
        {
            return Left + Right / 100.0;
        }

        public abstract string ToCurrency();
    }
}
