using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Traingle
    {
        public double Area(double SideA, double SideB, double SideC)
        {
            double semiperimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));  // Herons Formula
        }
        public double Perimeter(double SidaA, double SideB, double SideC)
        {
            return SidaA + SideB + SideC;
        }
    }
}
