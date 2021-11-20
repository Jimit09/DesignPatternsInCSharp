using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        public override ResponseObject Handle(RequestObject request)
        {
            request.RequestStagesProcessed.Add("I am AuthorizationHandler. I will only allow Authorized users/requests to access the resources. \n");
            return base.Handle(request);
        }
    }
}
