using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class CeiliingFanPullChainWithStatePattern
    {
        ISpeedState currentSpeed;

        public CeiliingFanPullChainWithStatePattern()
        {
            currentSpeed = new StoppedStateSpeed(this);
        }

        public void SetCurrentSpeedState(ISpeedState speedState)
        {
            this.currentSpeed = speedState;
        }

        public void Pull()
        {
            this.currentSpeed.Pull();
        }

        public SpeedNumber GetCurrentSpeed()
        {
            return currentSpeed.GetSpeedNumber();
        }
    }
}
