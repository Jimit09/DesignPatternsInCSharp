using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class CustomSortedList<T>
    {
        List<T> list;
        ISortStrategy<T> strategy;
        public CustomSortedList(ISortStrategy<T> strategy)
        {
            this.list = new List<T>();
            this.strategy = strategy;
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Sort()
        {
            this.strategy.Sort(list);
        }

        public List<T> GetList()
        {
            return list;
        }
    }
}
