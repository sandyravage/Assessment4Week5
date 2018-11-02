using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Week5
{
    class QuadrotorDrone : Drone
    {
        public override int FlightSpeed()
        {
            return base.FlightSpeed();
        }
    }/*S - Each of these classes only does one thing -- thats single responsiblity.
           they return the young calculated flightspeed value and store the variables
           needed to do it.
       O - The drone class is closed for editing - you cannot make changes to the fields
           other than by initializing it. It is open though cause we made the Quad
           drone which allowed us to extend that class and give it functionality
       L - There is a substitution at work here because you are able to use any children of
           of the parent class drone in place of the actual drone
       I - there are no implementations here of any interfaces that force anyone to use methods
           they dont need
       D - The drone class is an abstraction upon which children can be built. theres nothing
           theres nothing that would impact the higher level abstract classes if subsclasses
           are created.*/ 
}

