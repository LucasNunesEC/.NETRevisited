using System;
using System.Globalization;

namespace Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c = 0;

            Console.WriteLine("Enter the values of a,b,c separated by spaces: ");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0],CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = b * b - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossible to calculate");
            }
            else {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
