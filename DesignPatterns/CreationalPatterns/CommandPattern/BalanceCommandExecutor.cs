using DesignPatterns.CreationalPatterns.CommandPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern
{
    public class BalanceCommandExecutor : CommandExecutor
    {
        Repository repository;

        public BalanceCommandExecutor(Repository repository)
        {
            this.repository = repository;
        }

        public override bool IsApplicable(Command command)
        {
            return command.name == "balance";
        }

        protected override string ExecuteValidCommand(Command command)
        {
            string balance = this.repository.GetBalance();
            return "Current Balance is:" + balance;
        }

        protected override bool IsValid(Command command)
        {
            if (command.parameters[0] != "username")
            {
                throw new InvalidUserException();
            }
            string balance = this.repository.GetBalance();
            return true;
        }
    }
}
