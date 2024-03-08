using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotSet
{
    public struct Vector2d(double x, double y)
    {
        public double X = x;
        public double Y = y;

        public static Vector2d operator +(Vector2d x, Vector2d y) => new(x.X + y.X, x.Y + y.Y);
    }
}
