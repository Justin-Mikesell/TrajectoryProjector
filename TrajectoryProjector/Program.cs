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

            

            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.TerminalVelocity(1.5M, 1.68M, 3, 9.8M, 10.2040M));


            Falling_Object rectangle = new Falling_Object(100, 3, 1.68M);


            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.EarthTerminalVelocitySeaLevel(rectangle));


            Planet earth = new Planet(9.80665M, 1.5M);
            Planet mars = new Planet(3.71M, 0.020M);

            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.TerminalVelocity(earth, rectangle));

            

            Console.WriteLine("Terminal Velocity is: {0:N4}", Falling_Object.TerminalVelocity(mars, rectangle));

        }
    }
}
