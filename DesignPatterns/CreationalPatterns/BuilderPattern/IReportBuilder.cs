using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public interface IReportBuilder
    {
        public void BuildHeader();
        public void BuildFooter();
        public void BuildContentArea();
        public void BuildLeftAlignment();
        public void BuildRightAlignment();
        public IReport GetReport();
    }
}
