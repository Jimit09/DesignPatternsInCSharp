using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class InsertionSortStrategy<T> : ISortStrategy<T>
    {
        public void Sort(List<T> list)
        {
            //Assume sorted using Insertion Sort
            //TODO: Implement Insertion Sort

            list.Sort();
        }
    }
}
