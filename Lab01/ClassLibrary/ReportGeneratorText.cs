using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ReportGeneratorText : IGenerateReportText
    {      
        public static string GenerateReport_Text(Warehouse warehouse)
        {
            return "Date: " + warehouse.LastDeliveryDate.ToString() + "; Amount" + warehouse.Amount.ToString() + ";";
        }
    }
}
