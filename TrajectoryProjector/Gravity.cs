using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Falling_Object : Object
    {
        public static decimal time;

        //Given the earths gravity
        public readonly static decimal gravity = 9.8M;

        public static decimal mass;

        //given the density of air at sealevel
        // can be changed by user as needed
        public static decimal p_DensityofAir = 1.5M;

        public static decimal A_ProjectedAreaOfObject;

        public static decimal dragCoefficient;

        

        public Falling_Object(decimal Mass, decimal Length, decimal Width, decimal DragCoefficient)
        {
            mass = Mass;
            A_ProjectedAreaOfObject = Length * Width;
            dragCoefficient = DragCoefficient;
        }
        


        public static decimal FreeFallVelocity(decimal timeOfFlightInSeconds)
        {
            time = timeOfFlightInSeconds;
            decimal velocity = gravity * time;

            return velocity;
        }
        
        public static decimal FreeFallDistance(decimal timeOfFlightInSeconds)
        {
            time = timeOfFlightInSeconds;
            decimal distance = .5M * gravity * time * time;

            return distance;
        }

        public static decimal TerminalVelocity(decimal densityOfAir, decimal dragCoefficient, decimal projectedArea, decimal gravityOfPlanet, decimal mass)
        {
            decimal velocity = (2 * mass * gravityOfPlanet) / (densityOfAir * projectedArea * dragCoefficient);
            double velocityConvert = (double)velocity;
            double TV = Math.Sqrt(velocityConvert);
            decimal terminalVelocity = (decimal)TV;

            return terminalVelocity;
        }

        public static decimal EarthTerminalVelocitySeaLevel(decimal dragCoefficient, decimal projectedArea, decimal mass)
        {
            decimal velocity = (2 * mass * gravity) / (p_DensityofAir * projectedArea * dragCoefficient);
            double velocityConvert = (double)velocity;
            double TV = Math.Sqrt(velocityConvert);
            decimal terminalVelocity = (decimal)TV;
            

            return terminalVelocity;
        }

        public static decimal EarthTerminalVelocitySeaLevel(Falling_Object Object)
        {
            decimal velocity = (2 * mass * gravity) / (p_DensityofAir * A_ProjectedAreaOfObject * dragCoefficient);
            double velocityConvert = (double)velocity;
            double TV = Math.Sqrt(velocityConvert);
            decimal terminalVelocity = (decimal)TV;


            return terminalVelocity;
        }
    }
}
