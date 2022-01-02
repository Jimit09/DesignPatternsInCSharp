using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObjectPattern
{
    public class PdfReport : IReport
    {
        public string Display()
        {
            return "This is Pdf format Report";
        }
    }
}
