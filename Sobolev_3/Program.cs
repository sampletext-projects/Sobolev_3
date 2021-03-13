using System;

namespace Sobolev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = float.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = float.Parse(Console.ReadLine());
            Console.Write("B0=");
            double B0 = float.Parse(Console.ReadLine());
            Console.Write("Bk=");
            double Bk = float.Parse(Console.ReadLine());
            Console.Write("deltaB=");
            double deltaB = float.Parse(Console.ReadLine());

            for (double i = B0; i <= Bk; i += deltaB)
            {
                double R = (2.4 * Math.Cos(Math.Pow(a, 3) + Math.Sqrt(B0 * B0 - x))) / (Math.Pow(Math.E, a) + B0);

                Console.WriteLine("При B" + i + " R=" + R);
            }
        }
    }
}
