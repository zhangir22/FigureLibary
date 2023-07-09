using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibary
{
    public class Circle
    {
        public const double PI = 3.12;
        public int? Diameter { get; set; }
        public int? Raduis { get; set; }
        public int Square { get; set; }
        public Circle() { } 
        public Circle(int? d, int? r) 
        {
            if(d == null && r == null)
            {
                Diameter = 2;
                Raduis = 1;
                Square = FindSquare(Diameter, Raduis);
            }
            Diameter = d;
            Raduis = r;
            
        }
        public int FindSquare(int?diameter, int? radius)
        {
            const int HALF_DIAMETER = 2;
            const int NUMBER_FOR_FORMULA_RADIUS = 4;
            if (diameter == null && radius != null)
                return (int)(PI * (radius * radius));

            if (radius == null && diameter != null || radius != null && diameter != null && (radius * HALF_DIAMETER) == diameter)
                return (int)(PI * (diameter * diameter))/NUMBER_FOR_FORMULA_RADIUS;

            return 0;
        }
    }
}
