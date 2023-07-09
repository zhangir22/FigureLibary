using System.ComponentModel;

namespace FigureLibary.Test
{
    public class CircleTests
    {
        [Fact]
        public void FindSquare_diameter10return78()
        {
            int d = 10;
            int ex = 78;
            Circle c = new Circle(d, null);
            int act = c.FindSquare(c.Diameter, c.Raduis);
            Assert.Equal(ex, act);
        }
        [Fact]
        public void FindSquare_radius5return78()
        {
            int r = 5;
            int ex = 78;
            Circle c = new Circle(null,r);
            int act = c.FindSquare(c.Diameter, c.Raduis);
            Assert.Equal(ex, act);
        }

        [Fact]
        public void FindSquare_diameter10andradius5return78()
        {
            int d = 10;
            int r = 5;
            int ex = 78;
            Circle c = new Circle(d, r);
            int act = c.FindSquare(c.Diameter, c.Raduis);
            Assert.Equal(ex, act);
        }

    }
        
    
}