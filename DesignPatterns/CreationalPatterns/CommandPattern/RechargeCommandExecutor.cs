using DesignPatterns.CreationalPatterns.CommandPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern
{
    public class RechargeCommandExecutor : CommandExecutor
    {
        Repository repository;
        public RechargeCommandExecutor(Repository repository)
        {
            this.repository = repository;
        }
        public override bool IsApplicable(Command command)
        {
            return command.name == "recharge";
        }

        protected override string ExecuteValidCommand(Command command)
        {
            string balance = this.repository.GetBalance();
            if (Convert.ToInt32(balance) < Convert.ToInt32(command.parameters[2]))
            {
                throw new InsufficientBalanceException();
            }
            return "Recharge Done";
        }

        protected override bool IsValid(Command command)
        {
            if (command.parameters[0] != "username")
            {
                throw new InvalidUserException();
            }
            if (command.parameters[1] != "rechargeValue")
            {
                throw new InvalidParameterException();
            }
            return true;
        }
    }
}
