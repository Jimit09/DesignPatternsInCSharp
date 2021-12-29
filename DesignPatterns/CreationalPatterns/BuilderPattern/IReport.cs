using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public interface IReport
    {
        public abstract string Header { get; set; }
        public abstract string Footer { get; set; }
        public abstract string ContentArea { get; set; }
        public abstract string RightBorder { get; set; }
        public abstract string LeftBorder { get; set; }
    }
}
