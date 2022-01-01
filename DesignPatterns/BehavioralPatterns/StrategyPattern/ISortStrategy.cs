using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public interface ISortStrategy<T>
    {
        public void Sort(List<T> list);
    }
}
