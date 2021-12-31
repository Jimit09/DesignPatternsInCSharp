using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern
{
    public class CommandPatternExecutor : IExecute
    {
        public void Execute()
        {

            CommandRunner commandRunner = new CommandRunner(new List<ICommandExecutor>() {
                new RechargeCommandExecutor(new Repository()),
                new BalanceCommandExecutor(new Repository())
            });
            Command command = new Command() { name = "recharge", parameters = new List<string>() { "username", "rechargeValue", "10" } };
            Console.WriteLine(commandRunner.Run(command));
            command = new Command() { name = "balance", parameters = new List<string>() { "username", "Jimit" } };
            Console.WriteLine(commandRunner.Run(command));

        }
    }
}
