using System;

namespace triangleSquare
{
    class squareOfTriangle
    {
        static void Main(string[] args)
        {
            double S = 0, p = 0, a = 0;

            Console.WriteLine("Enter the perimeter of a regular triangle");
            p = Double.Parse(Console.ReadLine()) / 2;
            a = 2* p / 3;
            S = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            Console.WriteLine("Side   Square");
            Console.WriteLine("{0}   {1}", a, S);
        }
    }
}
