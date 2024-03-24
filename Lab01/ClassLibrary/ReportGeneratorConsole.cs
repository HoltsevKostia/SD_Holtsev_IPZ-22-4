using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ReportGeneratorConsole : IGenerateReportConsole
    {
        public void GenerateReport_Console(Warehouse warehouse)
        {        
            //DRY
            Console.WriteLine(ReportGeneratorText.GenerateReport_Text(warehouse));
        }
    }
}
