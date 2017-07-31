using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Area
    {
        public static decimal areaOfRectangle;
        public static decimal areaOfCircularDisc;
        public static decimal areaOfSphere;
        public static decimal projectedAreaOfRectangle;
        public static decimal projectedAreaOfCircularDisc;
        public static decimal projectedAreaOfSphere;

        public Area()
        {

        }

        public Area(decimal radiusOfSphere)
        {
            areaOfSphere = 4 * (decimal)Math.PI * (radiusOfSphere * radiusOfSphere);
            Console.WriteLine("Area of sphere is {0}", areaOfSphere);
        }

        public Area(double radiusOfDisc)
        {
            decimal r = (decimal)radiusOfDisc;
            areaOfCircularDisc = (decimal)Math.PI * (r * r);
            Console.WriteLine("Area of disc is {0}", areaOfCircularDisc);
        }

        public Area(decimal lengthOfRectangle, decimal widthOfRectangle)
        {
            areaOfRectangle = lengthOfRectangle * widthOfRectangle;
            Console.WriteLine("Area of rectangle is {0}", areaOfRectangle);
        }

       


        
    }
}
