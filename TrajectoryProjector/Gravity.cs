using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Gravity
    {
        public static decimal t;
        public readonly static decimal g = 9.8M;
        public static decimal m;
        public static decimal p = 1.225M;
        public static decimal A;
        public static decimal C;
        
        public static decimal FreeFallVelocity(decimal timeOfFlightInSeconds)
        {
            decimal t = timeOfFlightInSeconds;
            decimal velocity = g * t;

            return velocity;
        }
        
        public static decimal FreeFallDistance(decimal timeOfFlightInSeconds)
        {
            t = timeOfFlightInSeconds;
            decimal distance = .5M * g * t * t;

            return distance;
        }

        public static decimal TerminalVelocity(decimal ObjectRadiusInCentimeters, decimal ObjectDensityInGrams)
        {

        }
    }
}
