using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velocity will be {1} m/s It will be {0} meters away", Falling.FreeFallDistance(13), Falling.FreeFallVelocity(13));

            Object sphere = new Object(4M);

            Object disc = new Object(4.0);

            Object rectangle = new Object(4, 4);
           
        }
    }
}
