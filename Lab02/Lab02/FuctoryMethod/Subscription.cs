using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Subscription
    {
        public double MonthlyFee { get; }
        public int MinPeriod { get; }
        public List<string> Channels { get; }

        public Subscription(double monthlyFee, int minPeriod, List<string> channels)
        {
            MonthlyFee = monthlyFee;
            MinPeriod = minPeriod;
            Channels = channels;
        }

        public abstract string CreateSubscription();
    }
}
