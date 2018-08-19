using System;

namespace LargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var p0 = new Point { X = 0, Y = 0 };
            var p1 = new Point { X = 1, Y = 0 };
            var p2 = new Point { X = 1, Y = 1 };
            var p3 = new Point { X = 0, Y = 1 };
            var points = new Points() { p0, p1, p2, p3 };

            var max2 = Calc.GetLargestSquare(points);
            Console.WriteLine(max2);

            Console.ReadKey();
        }

    }
}