using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.CreationalPatterns.BuilderPattern;
using DesignPatterns.BehavioralPatterns.CommandPattern;
using DesignPatterns.CreationalPatterns.FactoryPattern;
using System;
using DesignPatterns.BehavioralPatterns.StrategyPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Patterns Tutorial by Jimit Gandhi!");

            //ChainOfResponsibilityExecuter chainOfResponsibilityExecuter = new ChainOfResponsibilityExecuter();
            //chainOfResponsibilityExecuter.Execute();

            //FactoryExecutor factoryExecutor = new FactoryExecutor();
            //factoryExecutor.Execute();

            //BuilderExecutor builderExecutor = new BuilderExecutor();
            //builderExecutor.Execute();

            //CommandPatternExecutor commandPatternExecutor = new CommandPatternExecutor();
            //commandPatternExecutor.Execute();

            StrategyPatternExecutor stratgeyPatternExecutor = new StrategyPatternExecutor();
            stratgeyPatternExecutor.Execute();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
