using System;
using System.Globalization;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma = 0, cont = 0;

            Console.WriteLine("Insira Média de Idades (use um valor negativo para parar)");

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                
                soma +=idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                double media = (double)soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();
            }
        }
    }
}
