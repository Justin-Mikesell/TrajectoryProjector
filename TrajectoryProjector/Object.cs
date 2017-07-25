using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrajectoryProjector
{
    class Object
    {
        public static decimal areaOfRectangle;
        public static decimal areaOfCircularDisc;
        public static decimal areaOfSphere;

        public Object()
        {

        }

        public Object(decimal radiusOfSphere)
        {
            areaOfSphere = 4 * (decimal)Math.PI * (radiusOfSphere * radiusOfSphere);
            Console.WriteLine("Area of sphere is {0}", areaOfSphere);
        }

        public Object(double radiusOfDisc)
        {
            decimal r = (decimal)radiusOfDisc;
            areaOfCircularDisc = (decimal)Math.PI * (r * r);
            Console.WriteLine("Area of disc is {0}", areaOfCircularDisc);
        }

        public Object(decimal lengthOfRectangle, decimal widthOfRectangle)
        {
            areaOfRectangle = lengthOfRectangle * widthOfRectangle;
            Console.WriteLine("Area of rectangle is {0}", areaOfRectangle);
        }
        
    }
}
