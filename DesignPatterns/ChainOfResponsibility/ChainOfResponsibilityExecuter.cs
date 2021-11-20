using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityExecuter : IExecute
    {
        public void Execute()
        {
            /*
             * Refer below link for ASP.Net Core request pipeline
             https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0#middleware-order
             */
            Console.WriteLine("Introducing Chain Of Responsibility Design pattern");
            Console.WriteLine("Here showcasing ASP.Net Core Request processing pipeline ");
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            AutheticationHandler autheticationHandler = new AutheticationHandler();
            AuthorizationHandler authorizationHandler = new AuthorizationHandler();
            RoutingHandler routingHandler = new RoutingHandler();
            autheticationHandler.SetNextHandler(authorizationHandler);
            authorizationHandler.SetNextHandler(routingHandler);
            exceptionHandler.SetNextHandler(autheticationHandler);
            RequestObject request = new RequestObject();
            exceptionHandler.Handle(request);

            foreach (var item in request.RequestStagesProcessed)
            {
                Console.WriteLine(item);
            }

        }
    }
}
