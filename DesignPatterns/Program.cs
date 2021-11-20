using DesignPatterns.ChainOfResponsibility;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Patterns Tutorial by Jimit Gandhi!");

            ChainOfResponsibilityExecuter chainOfResponsibilityExecuter = new ChainOfResponsibilityExecuter();
            chainOfResponsibilityExecuter.Execute();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
