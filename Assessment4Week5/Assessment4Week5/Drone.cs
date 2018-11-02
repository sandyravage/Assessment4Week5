using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Week5
{
    abstract class Drone
    {
        private int totalFlyTime; //minutes
        private int totalDistance; //feet

        public Drone()
        {

        }

        public Drone(int TotalFlyTime, int TotalDistance)
        {
            totalFlyTime = TotalFlyTime;
            totalDistance = TotalDistance;
        }

        public virtual int FlightSpeed() // returns in MPH
        {
            double calculatedSpeed = ((double)totalDistance / 5280) / ((double)totalFlyTime / 60);
            return (int)calculatedSpeed;
        }
    }
}
