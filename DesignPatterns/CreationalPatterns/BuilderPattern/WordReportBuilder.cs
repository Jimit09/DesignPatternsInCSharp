using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class WordReportBuilder : IReportBuilder
    {
        IReport report;

        public WordReportBuilder()
        {
            report = new WordReport();
        }

        public void BuildContentArea()
        {
            report.ContentArea = "This is word documents content area";
        }

        public void BuildFooter()
        {
            report.Footer = "This is word documents footer area";
        }

        public void BuildHeader()
        {
            report.Header = "This is word documents header area";
        }

        public void BuildLeftAlignment()
        {
            report.LeftBorder = "This is word documents left margin";
        }

        public void BuildRightAlignment()
        {
            report.RightBorder = "This is word documents right margin";
        }

        public IReport GetReport()
        {
            return report;
        }
    }
}
