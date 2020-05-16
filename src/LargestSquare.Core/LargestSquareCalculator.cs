using System.Collections.Generic;
using Tiles.Tools;

namespace LargestSquare.Core
{
    public class LargestSquareCalculator
    {
        public static (Tile startTile, int size) Calculate(List<Tile> tiles)
        {
            var largestsquare = 0;
            Tile starttile = null;

            foreach (var p in tiles)
            {
                var square = GetSquare(tiles, p);
                if (square > largestsquare)
                {
                    starttile = p;
                    largestsquare = square;
                }
            }

            return (starttile, largestsquare);
        }

        private static int GetSquare(List<Tile> tiles, Tile p)
        {
            var squaresize = 1;
            var makebigger = true;
            while (makebigger)
            {
                var hasring = HasNextRing(tiles, p, squaresize);

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

        private static bool HasNextRing(List<Tile> tiles, Tile p, int delta)
        {
            var j = p.Y + delta;
            for (var i = p.X; i <= p.X + delta; i++)
            {
                var hasPoint = HasPoint(tiles, i, j, p.Z);
                if (!hasPoint) { return false; }
            }

            var ii = p.X + delta;
            for (var jj = p.Y; jj <= p.Y + delta; jj++)
            {
                var hasPoint = HasPoint(tiles, ii, jj, p.Z);
                if (!hasPoint) { return false; }
            }

            return true;
        }

        private static bool HasPoint(List<Tile> tiles, int x, int y, int z)
        {
            var n = new Tile { X = x, Y = y, Z = z };
            return tiles.Contains(n);
        }
    }
}

