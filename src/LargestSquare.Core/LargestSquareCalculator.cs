using System.Collections.Generic;
using System.Linq;
using Tiles.Tools;

namespace LargestSquare.Core
{
    public class LargestSquareCalculator
    {
        public static List<Square> Calculate(List<Tile> tiles)
        {
            var res = new List<Square>();
            var largestsquare = 0;

            if (tiles.Count > 0)
            {
                var maxx = tiles.Select(t => t.X).Max();
                var maxy = tiles.Select(t => t.Y).Max();

                foreach (var tile in tiles)
                {
                    if (((maxx - tile.X + 1) >= largestsquare) && ((maxy - tile.Y + 1) >= largestsquare))
                    {
                        var square = GetSquare(tiles, tile);
                        if (square > largestsquare)
                        {
                            largestsquare = square;
                            res.Clear();
                        }
                        if (square >= largestsquare)
                        {
                            res.Add(new Square { Size = square, StartTile = tile });
                        }
                    }
                }
            }

            return res;
        }


        public static List<Tile> TryNextRingTiles(List<Tile> tiles, Tile startTile, int delta)
        {
            var res = new List<Tile>();

            for (var y = startTile.Y; y < startTile.Y + delta; y++)
            {
                res.Add(new Tile(startTile.X + delta-1, y, startTile.Z));
            }

            for (var x = startTile.X; x < startTile.X + delta - 1; x++)
            {
                res.Add(new Tile(x, startTile.Y + delta-1, startTile.Z));
            }

            return res;
        }


        private static int GetSquare(List<Tile> tiles, Tile startTile)
        {
            var squaresize = 1;
            var makebigger = true;
            while (makebigger)
            {
                var nextRingTiles = TryNextRingTiles(tiles, startTile, squaresize+1);
                var hasNextRing = HasTiles(tiles,nextRingTiles);
                if (hasNextRing)
                {
                    squaresize++;
                }
                else
                {
                    makebigger = false;
                }
            }

            return squaresize;
        }

        private static bool HasTiles(List<Tile> tiles, List<Tile> potentialTiles)
        {
            foreach (var potentialTile in potentialTiles)
            {
                if (!tiles.Contains(potentialTile))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

