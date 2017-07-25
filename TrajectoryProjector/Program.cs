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
            Console.WriteLine(Gravity.Velocity(13) + " m/s It will be {0} meters away", Gravity.Distance(13) );
        }
    }
}
