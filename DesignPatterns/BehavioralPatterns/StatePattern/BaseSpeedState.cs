using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public abstract class BaseSpeedState : ISpeedState
    {
        CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern;
        public BaseSpeedState(CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern)
        {
            this.ceiliingFanPullChainWithStatePattern = ceiliingFanPullChainWithStatePattern;
        }

        public abstract SpeedNumber GetSpeedNumber();

        public abstract void Pull();
    }
}
