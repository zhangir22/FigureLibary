using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibary
{
    public class Triangle
    {
        private protected List<string> ListType { get; set; } 
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public double Square { get; set; }
        public Triangle() { }
        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double FindSquareGeron(int sideA, int sideB, int sideC)
        {
            const int HALF_PERIMETER = 2;
            int semiperimeter = (sideA + sideB + sideC) / HALF_PERIMETER;
            var square = Math.Sqrt(semiperimeter * ((semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC)));
            return square;
        }
        public string DefineTriangle()
        {
            const int POWER = 2;
            if (SideA == SideB)
                return "isosceles";
            if (SideA == SideB && SideA == SideC && SideB == SideC)
                return "equilateral";
            if (SideA != SideB && SideA != SideC && SideB != SideC)
                return "versatile";
            if (Math.Pow(SideC, POWER) > (Math.Pow(SideA, POWER) + Math.Pow(SideB, POWER)))
                return "obtuse";
            if (Math.Pow(SideC, POWER) == (Math.Pow(SideA, POWER) + Math.Pow(SideB, POWER)))
                return "rectangular";
            if (Math.Pow(SideC, POWER) < (Math.Pow(SideA, POWER) + Math.Pow(SideB, POWER)))
                return "acute-angled";
            return null;
        }
    }
}
