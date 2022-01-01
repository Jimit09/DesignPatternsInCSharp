using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.CommandPattern
{
    public interface ICommandExecutor
    {
        public string Execute(Command command);
        public bool IsApplicable(Command command);
    }
}
