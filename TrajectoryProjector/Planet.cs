using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Planet : Area
    {
        public decimal gravity;
        public decimal atmosphereDensity;
        
        public Planet(decimal gravitationalPull, decimal atmosphericDensity)
        {
            gravity = gravitationalPull;
            atmosphereDensity = atmosphericDensity;
        }
    }
}
