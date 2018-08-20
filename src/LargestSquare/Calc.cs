namespace LargestSquare
{
    public class Calc
    {
        public static int GetLargestSquare(Points points)
        {
            var largestsquare = 0;

            foreach (var p in points)
            {
                var square = points.GetSquare(p);
                if (square > largestsquare)
                {
                    largestsquare = square;
                }
            }

            return largestsquare;
        }

    }
}

