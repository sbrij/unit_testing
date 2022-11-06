using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Circle
    {
        public double Area(double Radius)
        {
            return Radius * Radius * Math.PI;
        }
        public double Perimeter(double Radius)
        {
            return 2 * Radius * Math.PI;
        }
    }
}