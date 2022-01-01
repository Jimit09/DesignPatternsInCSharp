using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class MergeSortStrategy<T> : ISortStrategy<T>
    {
        public void Sort(List<T> list)
        {
            //Assume sorted using Merge Sort
            //TODO: Implement Merge Sort
            list.Sort();
        }
    }
}
