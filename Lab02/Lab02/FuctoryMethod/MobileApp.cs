using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MobileApp
    {
        public static string PurchaseSubscription(string subType)
        {
            return "Thank you for signing up through our app!\n" + SubscriptionFactory.SubscriptionType(subType).CreateSubscription();
        }

    }
}
