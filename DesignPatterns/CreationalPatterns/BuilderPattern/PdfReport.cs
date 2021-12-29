using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class PdfReport : IReport
    {
        public string Header { get; set; }
        public string Footer { get; set; }
        public string ContentArea { get; set; }
        public string RightBorder { get; set; }
        public string LeftBorder { get; set; }

        public override string ToString()
        {
            return Header + ContentArea + Footer + LeftBorder + RightBorder;
        }
    }
}
