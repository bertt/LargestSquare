using LargestSquare.Core;
using NUnit.Framework;
using System.Collections.Generic;
using Tiles.Tools;

namespace LargestSquare.Tests
{
    public class Tests
    {
        private List<Tile> tiles;

        [SetUp]
        public void Setup()
        {
            var p0 = new Tile { X = 0, Y = 0, Z = 0 };
            var p1 = new Tile { X = 1, Y = 0, Z = 0 };
            var p2 = new Tile { X = 1, Y = 1, Z = 0 };
            var p3 = new Tile { X = 0, Y = 1, Z = 0 };

            tiles = new List<Tile> { p0, p1, p2, p3};
        }

        [Test]
        public void Test1()
        {
            var res = LargestSquareCalculator.Calculate(tiles);

            Assert.IsTrue(res.Count == 1);
            Assert.IsTrue(res[0].StartTile.Equals(tiles[0]));
        }

        [Test]
        public void Test3()
        {
            var res = LargestSquareCalculator.Calculate(new List<Tile>());
            Assert.IsTrue(res.Count== 0);
        }

        [Test]
        public void LargestSquareTest()
        {
            var p0 = new Tile { X = 5, Y = 10, Z = 10 };
            var p1 = new Tile { X = 6, Y = 10, Z = 10 };
            var p2 = new Tile { X = 5, Y = 11, Z = 10 };
            var p3 = new Tile { X = 6, Y = 11, Z = 10 };
            var p4 = new Tile { X = 5, Y = 12, Z = 10 };
            var p5 = new Tile { X = 6, Y = 12, Z = 10 };
            tiles = new List<Tile> { p1, p2, p3, p0, p4, p5};
            var res = LargestSquareCalculator.Calculate(tiles);
            Assert.IsTrue(res.Count == 2);
            Assert.IsTrue(res[0].StartTile.Equals(p2)); 
            Assert.IsTrue(res[1].StartTile.Equals(p0)); 
        }


        [Test]
        public void GetNextRingTilesTest()
        {
            var p0 = new Tile { X = 5, Y = 10, Z = 10 };
            var p1 = new Tile { X = 6, Y = 10, Z = 10 };
            var p2 = new Tile { X = 5, Y = 11, Z = 10 };
            var p3 = new Tile { X = 6, Y = 11, Z = 10 };

            tiles = new List<Tile> { p0, p1, p2, p3};

            var nextRingTiles = LargestSquareCalculator.TryNextRingTiles(tiles, p0, 3);

            Assert.IsTrue(nextRingTiles.Count == 5);
            Assert.IsTrue(nextRingTiles[0].Equals(new Tile(7, 10, 10)));
            Assert.IsTrue(nextRingTiles[1].Equals(new Tile(7, 11, 10)));
            Assert.IsTrue(nextRingTiles[2].Equals(new Tile(7, 12, 10)));
            Assert.IsTrue(nextRingTiles[3].Equals(new Tile(5, 12, 10)));
            Assert.IsTrue(nextRingTiles[4].Equals(new Tile(6, 12, 10)));
        }
    }
}