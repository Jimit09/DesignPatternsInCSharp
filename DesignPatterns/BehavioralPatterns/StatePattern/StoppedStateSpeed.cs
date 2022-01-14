using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class StoppedStateSpeed : BaseSpeedState
    {
        CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern;

        public StoppedStateSpeed(CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern) :
            base(ceiliingFanPullChainWithStatePattern)
        {
            this.ceiliingFanPullChainWithStatePattern = ceiliingFanPullChainWithStatePattern;
        }
        public override SpeedNumber GetSpeedNumber()
        {
            return SpeedNumber.Stopped;
        }

        public override void Pull()
        {
            this.ceiliingFanPullChainWithStatePattern.SetCurrentSpeedState(new LowSpeed(this.ceiliingFanPullChainWithStatePattern));
        }
    }
}
