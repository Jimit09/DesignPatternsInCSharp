using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObjectPattern
{
    public class ReportClient
    {
        public static List<IReport> RunReport(List<string> types)
        {
            List<IReport> reports = new List<IReport>();
            foreach (var type in types)
            {
                reports.Add(GetReport(type));
            }
            return reports;
        }

        private static IReport GetReport(string type)
        {
            switch (type)
            {
                case "Pdf":
                    return new PdfReport();
                case "Excel":
                    return new ExcelReport();
                default:
                    return new NullReport();
            }
        }
    }
}
