using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public interface ISpeedState
    {
        public void Pull();
        public SpeedNumber GetSpeedNumber();
    }
}
