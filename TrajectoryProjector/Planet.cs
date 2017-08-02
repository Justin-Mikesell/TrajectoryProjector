using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Planet : Area
    {
        private decimal gravity;
        private decimal atmosphereDensity;
        
        public Planet(decimal gravitationalPull, decimal atmosphericDensity)
        {
            gravity = gravitationalPull;
            atmosphereDensity = atmosphericDensity;
        }

        public decimal PlanetDensity 
        {
            get { return atmosphereDensity; }
            set { atmosphereDensity = value; }
        }

        public decimal PlanetGravity
        {
            get { return gravity; }
            set { gravity = value; }
        }
    }
}
