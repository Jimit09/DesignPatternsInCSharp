using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class PdfReportBuilder : IReportBuilder
    {
        IReport report;

        public PdfReportBuilder()
        {
            report = new PdfReport();
        }
        public void BuildContentArea()
        {
            report.ContentArea = "This is pdf documents content area";
        }

        public void BuildFooter()
        {
            report.Footer = "This is pdf documents footer area";
        }

        public void BuildHeader()
        {
            report.Header = "This is pdf documents header area";
        }

        public void BuildLeftAlignment()
        {
            report.LeftBorder = "This is pdf documents left margin";
        }

        public void BuildRightAlignment()
        {
            report.RightBorder = "This is pdf documents right margin";
        }

        public IReport GetReport()
        {
            return report;
        }
    }
}
