using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class StatePatternExecutor : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("CeilingFanPullChain implementation Without State Pattern");
            CeiliingFanPullChainWithoutStatePattern ceiliingFanPullChainWithoutStatePattern = new CeiliingFanPullChainWithoutStatePattern();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Current Speed: " + (int)ceiliingFanPullChainWithoutStatePattern.GetCurrentSpeed());
                Console.WriteLine("Changing Speed");
                ceiliingFanPullChainWithoutStatePattern.Pull();
            }

            Console.WriteLine("CeilingFanPullChain implementation With State Pattern");
            CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern = new CeiliingFanPullChainWithStatePattern();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Current Speed: " + (int)ceiliingFanPullChainWithStatePattern.GetCurrentSpeed());
                Console.WriteLine("Changing Speed");
                ceiliingFanPullChainWithStatePattern.Pull();
            }

            //TODO:To avoid coupling between states, create State Configuration json of following format
            //And use reflection to build classes and its dependants
            /*
             {
                defaultState: { StateName: StoppedStateSpeed },
                SpeedsList: [
                    { Name: StoppedStateSpeed, NextSpeed:  LowSpeed},
                    { Name: LowSpeed, NextSpeed:  MediumSpeed}, 
                    { Name: MediumSpeed, NextSpeed:  MediumSpeed}, 
                    { Name: MediumSpeed, NextSpeed:  HighSpeed}, 
                    { Name: HighSpeed, NextSpeed:  StoppedStateSpeed}
                ]
             }
             
             */
        }
    }
}
