using DesignPatterns.BehavioralPatterns.CommandPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.CommandPattern
{
    public class BadDesignWithoutCommandPattern
    {
        Repository repository;
        public BadDesignWithoutCommandPattern(Repository repository)
        {
            this.repository = repository;
        }

        public string ExecuteAppFeature(Command command)
        {
            if (command.name == "balance")
            {
                if (command.parameters[0] != "username")
                {
                    throw new InvalidUserException();
                }
                string balance = this.repository.GetBalance();
                return balance;
            }
            else if (command.name == "recharge")
            {
                if (command.parameters[0] != "username")
                {
                    throw new InvalidUserException();
                }
                if (command.parameters[1] != "rechargeValue")
                {
                    throw new InvalidParameterException();
                }
                string balance = this.repository.GetBalance();
                if (Convert.ToInt32(balance) < Convert.ToInt32(command.parameters[0]))
                {
                    throw new InsufficientBalanceException();
                }
                return "Recharge Done";
            }
            else
            {
                return null;
            }
        }
    }
}
