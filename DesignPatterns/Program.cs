﻿using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.CreationalPatterns.BuilderPattern;
using DesignPatterns.CreationalPatterns.CommandPattern;
using DesignPatterns.CreationalPatterns.FactoryPattern;
using System;

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

            CommandPatternExecutor commandPatternExecutor = new CommandPatternExecutor();
            commandPatternExecutor.Execute();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
