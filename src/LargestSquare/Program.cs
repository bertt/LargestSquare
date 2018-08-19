using System;

namespace LargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 20000;
            var m = new int[w,w];
            m[0, 0] = 1;
            m[1, 1] = 1;
            m[1, 0] = 1;
            m[0, 1] = 1;
            m[2, 2] = 1;
            // expected output: 2
            Console.WriteLine("Largest sub square: " + Calc.GetMaxSubSquare(m,w,w));
            Console.ReadKey();
        }
    }
}