using System;
using System.Globalization;

namespace Class04
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of operations: ");
            int N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++) {
                Console.WriteLine("Insert Pairs to be divided: ");
                string[] vet = Console.ReadLine().Split(' ');
                double x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double x2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

                double result = x1 / x2;

                if (x2 == 0)
                {
                    Console.WriteLine("Impossivel Calcular");
                }
                else {
                    Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();
        }
    }
}
