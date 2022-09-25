using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Circle : IShape
    {
        double radius;
        const double p = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            double area = p * Math.Pow(radius, 2);
            return area;
        }
    }
}
