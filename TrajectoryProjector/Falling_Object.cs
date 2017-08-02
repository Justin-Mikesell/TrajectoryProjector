using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Falling_Object : Area
    {
        private static decimal time;

        //Given the earths gravity
        private static decimal gravity = 9.80665M;

        private static decimal mass;

        //given the density of air at sealevel
        // can be changed by user as needed
        private static decimal p_DensityofAir = 1.225M;

        private static decimal A_ProjectedAreaOfObject;

        private static decimal dragCoefficient;



        public Falling_Object(decimal weightInKg, decimal ProjectedAreaOfObject, decimal DragCoefficient)
        {
            mass = weightInKg / gravity;
            A_ProjectedAreaOfObject = ProjectedAreaOfObject;
            dragCoefficient = DragCoefficient;
        }

        public decimal ObjectWeight
        {
            get { return mass; }
            set { mass = value / gravity; }
        }

        public decimal ProjectedArea
        {
            get { return A_ProjectedAreaOfObject; }
            set { A_ProjectedAreaOfObject = value; }
        }

        public decimal DragCoefficient
        {
            get { return dragCoefficient; }
            set { dragCoefficient = value; }
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

        public static decimal TerminalVelocity(Planet planet, Falling_Object Object)
        {
            decimal velocity = (2 * mass * planet.PlanetGravity ) / (planet.PlanetDensity * A_ProjectedAreaOfObject * dragCoefficient);

            double velocityConvert = (double)velocity;
            double TV = Math.Sqrt(velocityConvert);
            decimal terminalVelocity = (decimal)TV;


            return terminalVelocity;
        }
    }
}
