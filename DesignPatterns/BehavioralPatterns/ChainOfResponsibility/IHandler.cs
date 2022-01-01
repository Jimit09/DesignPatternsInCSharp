using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        public ResponseObject Handle(RequestObject request);
        public IHandler SetNextHandler(IHandler handler);
    }
}
