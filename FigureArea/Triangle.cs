using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle :IShape
    {
        public Triangle(float a,float b, float c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public float a;
        public float b;
        public float c;

        public float CalculateArea()
        {
            return FigureArea.TriangleSquare(a, b, c);
        }
    }
}
