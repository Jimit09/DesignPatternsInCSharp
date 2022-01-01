using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class ExceptionHandler : BaseHandler
    {
        public override ResponseObject Handle(RequestObject requestObject)
        {
            try
            {
                return base.Handle(requestObject);
            }
            catch (Exception ex)
            {
                ResponseObject responseObject = new ResponseObject() { Content = " I am ExceptionHandler. I handle all the mess created in the app.\n", StatusCode = 500 };
                return responseObject;
            }
        }
    }
}
