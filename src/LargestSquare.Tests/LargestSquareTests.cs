using LargestSquare.Core;
using NUnit.Framework;
using Tiles.Tools;

namespace LargestSquare.Tests
{
    public class Tests
    {
        private Tiles tiles;

        [SetUp]
        public void Setup()
        {
            var p0 = new Tile { X = 0, Y = 0, Z = 10 };
            var p1 = new Tile { X = 1, Y = 0, Z = 10 };
            var p2 = new Tile { X = 1, Y = 1, Z = 10 };
            var p3 = new Tile { X = 0, Y = 1, Z = 10 };

            tiles = new Tiles() { p0, p1, p2, p3 };
        }

        [Test]
        public void Test1()
        {
            var max2 = Calc.GetLargestSquare(tiles);

            Assert.IsTrue(max2 == 2); 
        }

        [Test]
        public void Test2()
        {
            var square = tiles.GetSquare(tiles[0]);
            Assert.IsTrue(square == 2);
        }

        [Test]
        public void Test3()
        {
            var square = Calc.GetLargestSquare(new Tiles());
            Assert.IsTrue(square == 0);
        }    
    }
}