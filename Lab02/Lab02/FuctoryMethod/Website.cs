using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Website
    {
        public static string PurchaseSubscription(string subType)
        {
            return "Thank you for signing up through our website!\n" + SubscriptionFactory.SubscriptionType(subType).CreateSubscription(); 
        }
    }
}
