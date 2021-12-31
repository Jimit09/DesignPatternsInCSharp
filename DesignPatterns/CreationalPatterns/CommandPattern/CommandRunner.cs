using DesignPatterns.CreationalPatterns.CommandPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern
{
    public class CommandRunner
    {
        List<ICommandExecutor> commandExecutors;

        public CommandRunner(List<ICommandExecutor> commandExecutors)
        {
            this.commandExecutors = commandExecutors;
        }

        public string Run(Command command)
        {
            foreach (var commandExecutor in commandExecutors)
            {
                if (commandExecutor.IsApplicable(command))
                {
                    return commandExecutor.Execute(command);
                }
            }
            throw new InvalidCommandException();
        }
    }
}
