using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class ReportDirector
    {
        IReportBuilder reportBuilder;
        public ReportDirector(IReportBuilder reportBuilder)
        {
            this.reportBuilder = reportBuilder;
        }

        public IReport ConstructReport()
        {
            reportBuilder.BuildHeader();
            reportBuilder.BuildContentArea();
            reportBuilder.BuildHeader();
            reportBuilder.BuildFooter();
            reportBuilder.BuildRightAlignment();
            reportBuilder.BuildLeftAlignment();
            return reportBuilder.GetReport();
        }
    }
}
