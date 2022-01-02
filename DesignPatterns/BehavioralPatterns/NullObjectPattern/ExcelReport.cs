using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObjectPattern
{
    public class ExcelReport : IReport
    {
        public string Display()
        {
            return "This is Excel format Report";
        }
    }
}
