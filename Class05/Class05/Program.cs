using System;
using System.Globalization;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            X.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.Area();
            areaY = Y.Area();

            Console.WriteLine("AREA DO TRIAGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIAGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
