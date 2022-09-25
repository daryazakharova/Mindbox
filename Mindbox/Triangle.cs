using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Triangle : IShape
    {
        public double AB;
        public double BC;
        public double AC;


        public Triangle(double ab, double bc, double ac)
        {
            this.AB = ab;
            this.BC = bc;
            this.AC = ac;
            if ((Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2)) ||
                (Math.Pow(AB, 2) + Math.Pow(AC, 2) == Math.Pow(BC, 2)) ||
                (Math.Pow(AC, 2) + Math.Pow(BC, 2) == Math.Pow(AB, 2)))
            {
                Console.WriteLine("Triangle is right!");
            }

        }

        public double Area()
        {
            double perimetr = (AB + BC + AC) / 2;
            double area = Math.Sqrt(perimetr * (perimetr - AB) * (perimetr - BC) * (perimetr - AC));
            return area;
        }
    }
}
