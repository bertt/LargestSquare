using System;

namespace LargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 40000;
            var m = new bool[w,w];
            m[0, 0] = true;
            m[1, 1] = true;
            m[1, 0] = true;
            m[0, 1] = true;
            m[2, 2] = true;
            // expected output: 2
            Console.WriteLine("Largest sub square: " + Calc.GetMaxSubSquare(m,w,w));
            Console.ReadKey();
        }
    }
}