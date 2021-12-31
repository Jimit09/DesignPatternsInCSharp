using DesignPatterns.CreationalPatterns.CommandPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern
{
    public abstract class CommandExecutor : ICommandExecutor
    {
        public string Execute(Command command)
        {
            if (!IsValid(command))
            {
                throw new InvalidCommandException();
            }
            return ExecuteValidCommand(command);
        }

        protected abstract bool IsValid(Command command);

        protected abstract string ExecuteValidCommand(Command command);

        public abstract bool IsApplicable(Command command);
    }
}
