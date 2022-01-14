using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class HighSpeed : BaseSpeedState
    {
        CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern;

        public HighSpeed(CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern) : base(ceiliingFanPullChainWithStatePattern)
        {
            this.ceiliingFanPullChainWithStatePattern = ceiliingFanPullChainWithStatePattern;
        }

        public override SpeedNumber GetSpeedNumber()
        {
            return SpeedNumber.High;
        }

        public override void Pull()
        {
            this.ceiliingFanPullChainWithStatePattern.SetCurrentSpeedState(new StoppedStateSpeed(this.ceiliingFanPullChainWithStatePattern));
        }
    }
}
