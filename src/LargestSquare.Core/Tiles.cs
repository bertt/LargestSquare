using System.Collections.Generic;
using Tiles.Tools;

namespace LargestSquare
{
    public class Tiles : List<Tile>
    {
        // get the square to the right and bottom (if any)
        public int GetSquare(Tile p)
        {
            var squaresize = 1;
            var makebigger = true;
            while (makebigger)
            {
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

        private bool HasNextRing(Tile p, int delta)
        {
            var j = p.Y + delta;
            for (var i = p.X; i <= p.X + delta; i++)
            {
                var hasPoint = HasPoint(i, j,p.Z);
                if (!hasPoint) { return false; }
            }

            var ii = p.X + delta;
            for (var jj = p.Y; jj <= p.Y + delta; jj++)
            {
                var hasPoint = HasPoint(ii, jj, p.Z);
                if (!hasPoint) { return false; }
            }

            return true;
        }

        private bool HasPoint(int x, int y, int z)
        {
            var n = new Tile { X = x, Y = y, Z=z };
            return Contains(n);
        }
    }

}
