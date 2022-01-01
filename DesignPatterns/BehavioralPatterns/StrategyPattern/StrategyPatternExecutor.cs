using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class StrategyPatternExecutor : IExecute
    {
        public void Execute()
        {
            List<int> inputList = new List<int>() { 8, 4, 1, 6, 9 };
            Console.WriteLine("Before sorting:");
            Print(inputList);

            ISortStrategy<int> sortStrategy = new MergeSortStrategy<int>();
            CustomSortedList<int> customSortedList = new CustomSortedList<int>(sortStrategy);
            foreach (var item in inputList)
            {
                customSortedList.Add(item);
            }
            customSortedList.Sort();
            Console.WriteLine("After sorting:");
            Print(customSortedList.GetList());
        }

        public void Print(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
