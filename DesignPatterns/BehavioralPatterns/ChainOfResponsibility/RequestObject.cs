using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class RequestObject
    {
        public RequestObject()
        {
            RequestStagesProcessed = new List<string>();
        }

        public Guid Id { get; set; }
        public string Content { get; set; }

        public string RequestHeaders { get; set; }

        public List<string> RequestStagesProcessed { get; private set; }
    }
}
