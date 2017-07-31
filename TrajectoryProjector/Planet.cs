using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Planet
    {
        public static decimal planetGravity;
        public static decimal airDensity;

        public Planet(decimal gravitationalPull, decimal atmosphericDensity)
        {
            planetGravity = gravitationalPull;
            airDensity = atmosphericDensity;
        }
    }
}
