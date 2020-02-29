namespace LargestSquare.Core
{
    public class Calc
    {
        public static int GetLargestSquare(Tiles tiles)
        {
            var largestsquare = 0;

            foreach (var p in tiles)
            {
                var square = tiles.GetSquare(p);
                if (square > largestsquare)
                {
                    largestsquare = square;
                }
            }

            return largestsquare;
        }

    }
}

