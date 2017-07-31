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
            Console.WriteLine("Velocity will be {1} m/s It will be {0} meters away", Falling_Object.FreeFallDistance(13), Falling_Object.FreeFallVelocity(13));

            

            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.TerminalVelocity(1.5M, 1.68M, 9, 9.8M, 200));

            Falling_Object rectangle = new Falling_Object(200, 3, 3, 1.68M);

            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.EarthTerminalVelocitySeaLevel(rectangle));
           
        }
    }
}
