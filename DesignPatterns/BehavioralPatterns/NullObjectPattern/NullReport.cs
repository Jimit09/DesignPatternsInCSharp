using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObjectPattern
{
    public class NullReport : IReport
    {
        public string Display()
        {
            return "The type specified is not supported";
        }
    }
}
