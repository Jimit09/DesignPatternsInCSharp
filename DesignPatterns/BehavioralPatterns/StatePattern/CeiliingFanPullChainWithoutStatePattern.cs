using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class CeiliingFanPullChainWithoutStatePattern
    {
        SpeedNumber currentSpeed;

        public CeiliingFanPullChainWithoutStatePattern()
        {
            currentSpeed = SpeedNumber.Stopped;
        }

        public void Pull()
        {
            switch (currentSpeed)
            {
                case SpeedNumber.Stopped:
                    currentSpeed = SpeedNumber.Low;
                    break;
                case SpeedNumber.Low:
                    currentSpeed = SpeedNumber.Medium;
                    break;
                case SpeedNumber.Medium:
                    currentSpeed = SpeedNumber.High;
                    break;
                case SpeedNumber.High:
                    currentSpeed = SpeedNumber.Stopped;
                    break;
                default:
                    currentSpeed = SpeedNumber.Stopped;
                    break;
            }
        }

        public SpeedNumber GetCurrentSpeed()
        {
            return currentSpeed;
        }
    }
}

