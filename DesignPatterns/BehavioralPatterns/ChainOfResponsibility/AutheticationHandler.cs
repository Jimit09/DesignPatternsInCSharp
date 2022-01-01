using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class AutheticationHandler : BaseHandler
    {
        public override ResponseObject Handle(RequestObject request)
        {
            request.RequestStagesProcessed.Add("I am AutheticationHandler. I will only allow authenticated users/requests to enter the system.\n");
            return base.Handle(request);
        }
    }
}
