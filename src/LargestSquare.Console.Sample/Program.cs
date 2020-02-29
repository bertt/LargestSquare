using LargestSquare.Core;
using System;
using System.Collections.Generic;
using Tiles.Tools;

namespace LargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var p0 = new Tile { X = 0, Y = 0, Z=10 };
            var p1 = new Tile { X = 1, Y = 0, Z=10 };
            var p2 = new Tile { X = 1, Y = 1, Z=10 };
            var p3 = new Tile { X = 0, Y = 1, Z=10 };

            var tiles = new List<Tile>() { p0, p1, p2, p3 };

            var max2 = LargestSquareCalculator.Calculate(tiles);
            Console.WriteLine(max2);

            Console.ReadKey();
        }

    }
}