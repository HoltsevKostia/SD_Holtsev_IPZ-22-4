using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(30, 12, new List<string> { "Channel A", "Channel B", "Channel C", "Channel D" }) { }

        public override string CreateSubscription()
        {
            return $"Premium Subscription: Fee - {MonthlyFee}, Min Period - {MinPeriod}, Channels - {string.Join(", ", Channels)}";
        }
    }
}
