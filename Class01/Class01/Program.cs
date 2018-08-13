using System;
using System.Globalization;

namespace Class01
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Bem vindo, insira seu nome: ");
            String nome = Console.ReadLine();
            
            Console.WriteLine("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + nome + " de idade " + idade + " anos");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            Console.ReadKey();

        }
    }
}
