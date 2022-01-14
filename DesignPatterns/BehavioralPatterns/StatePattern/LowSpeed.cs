using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class LowSpeed : BaseSpeedState
    {
        CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern;

        public LowSpeed(CeiliingFanPullChainWithStatePattern ceiliingFanPullChainWithStatePattern) : base(ceiliingFanPullChainWithStatePattern)
        {
            this.ceiliingFanPullChainWithStatePattern = ceiliingFanPullChainWithStatePattern;
        }

        public override SpeedNumber GetSpeedNumber()
        {
            return SpeedNumber.Low;
        }

        public override void Pull()
        {
            this.ceiliingFanPullChainWithStatePattern.SetCurrentSpeedState(new MediumSpeed(this.ceiliingFanPullChainWithStatePattern));
        }
    }
}
