using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : IShape
    {
        public Circle(float radius) { 
            this.radius = radius;
        }
        public float radius;

        public float CalculateArea()
        {
            return FigureArea.CircleSquare(radius);
        }
    }
}
