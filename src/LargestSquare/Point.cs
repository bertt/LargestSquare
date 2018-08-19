using System;
using System.Collections.Generic;

namespace LargestSquare
{
    public class Point:IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool Equals(Point other)
        {
            if (other == null) return false;
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public static implicit operator int(Point v)
        {
            throw new NotImplementedException();
        }
    }

    public class Points : List<Point>
    {
        // get the square to the right and bottom (if any)
        public int GetSquare(Point p) {
            var squaresize = 1;
            var makebigger = true;
            while (makebigger) {
                var hasring = HasNextRing(p, squaresize);

                if (!hasring)
                {
                    makebigger = false;
                }
                else
                {
                    squaresize++;
                }
            }

            return squaresize;
        }

        private bool HasNextRing(Point p, int delta)
        {
            var j = p.Y + delta;
            for (var i = p.X; i <= p.X + delta;i++)
            {
                var hasPoint = HasPoint(i, j);
                if (!hasPoint) { return false; }
            }

            var ii = p.X + delta;
            for (var jj = p.Y; jj <= p.Y + delta; jj++)
            {
                var hasPoint = HasPoint(ii, jj);
                if (!hasPoint) { return false; }
            }

            return true;
        }

        private bool HasPoint(int x, int y)
        {
            var n = new Point { X = x, Y = y};
            return Contains(n);
        }
    }
}
