using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ResponseObject
    {
        public string Content { get; set; }
        public string ResponseHeaders { get; set; }
        public double StatusCode { get; set; }
    }
}
