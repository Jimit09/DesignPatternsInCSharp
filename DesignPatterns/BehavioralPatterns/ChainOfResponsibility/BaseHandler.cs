using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual ResponseObject Handle(RequestObject request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            return new ResponseObject() { Content = "Returned from base handler" };
        }

        public IHandler SetNextHandler(IHandler handler)
        {
            this._nextHandler = handler;
            return this._nextHandler;
        }
    }
}
