using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(20, 12, new List<string> { "Channel C", "Channel D" }) { }

        public override string CreateSubscription()
        {
            return $"Educational Subscription: Fee - {MonthlyFee}, Min Period - {MinPeriod}, Channels - {string.Join(", ", Channels)}";
        }
    }
}
