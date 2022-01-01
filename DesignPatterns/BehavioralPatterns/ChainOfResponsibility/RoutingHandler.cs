using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class RoutingHandler: BaseHandler
    {
        public override ResponseObject Handle(RequestObject request)
        {
            request.RequestStagesProcessed.Add("I am RoutingHandler. I match the incoming request to the API Endpoint.\n");
            return base.Handle(request);
        }
    }
}
