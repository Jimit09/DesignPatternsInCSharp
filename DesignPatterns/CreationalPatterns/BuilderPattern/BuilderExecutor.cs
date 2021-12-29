using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class BuilderExecutor : IExecute
    {
        public void Execute()
        {
            IReportBuilder reportBuilder = new PdfReportBuilder();
            ReportDirector reportDirector = new ReportDirector(reportBuilder);
            Console.WriteLine(reportDirector.ConstructReport());
        }
    }
}
