using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibary.Test
{
    public class TriangleTests
    {
        [Fact]
        public void FindSquareGeron_a20_b23_c21return195()
        {
            int a = 20;
            int b = 23;
            int c = 21;
            int ex = 195;
            Triangle t = new Triangle(a,b,c);
            int act = Convert.ToInt32(t.FindSquareGeron(t.SideA,t.SideB,t.SideC));
            Assert.Equal(ex, act);
        }
        [Fact]
        public void DefineTriangle_a20_b23_c21return195()
        {
            int a = 20;
            int b = 23;
            int c = 21;
            string ex = "versatile";
            Triangle t = new Triangle(a, b, c);
            string act = t.DefineTriangle();
            Assert.Equal(ex, act);
        }
    }
}
