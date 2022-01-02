using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObjectPattern
{
    public class NullObjectPatternExecutor : IExecute
    {
        public void Execute()
        {
            List<string> types = new List<string>() { "Pdf", "Excel", "" };
            var result = ReportClient.RunReport(types);
            foreach (var item in result)
            {
                Console.WriteLine(item.Display());
            }
        }
    }
}
