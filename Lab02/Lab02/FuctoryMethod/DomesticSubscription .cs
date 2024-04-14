using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(10, 6, new List<string> { "Channel A", "Channel B" }) { }

        public override string CreateSubscription()
        {
            return $"Domestic Subscription: Fee - {MonthlyFee}, Min Period - {MinPeriod}, Channels - {string.Join(", ", Channels)}";
        }
    }
}
