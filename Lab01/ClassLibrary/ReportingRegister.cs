using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ReportingRegister
    {

        public static void RegisterIncoming(Warehouse warehouse, int amount, DateTime deliveryDate)
        {
            if (warehouse != null)
            {
                warehouse.Amount += amount;
                warehouse.LastDeliveryDate = deliveryDate;
            }
            else
            {
                throw new Exception("No such warehouse.");
            }
        }

        public static void RegisterOutgoing(Warehouse warehouse, int amount)
        {
            if (warehouse != null)
            {                
                if (warehouse.Amount - amount < 0)
                {
                    throw new InvalidOperationException("Luck of products in stock to fulfill the outgoing request.");
                }
                else
                {
                    warehouse.Amount -= amount;
                }
            }
            else
            {
                throw new InvalidOperationException("No such warehouse.");
            }
        }
    }
}
