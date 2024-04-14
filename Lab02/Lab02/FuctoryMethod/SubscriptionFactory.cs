using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SubscriptionFactory
    {
        public static Subscription SubscriptionType(string subType)
        {
            switch (subType.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
