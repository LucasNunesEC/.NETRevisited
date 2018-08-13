using System;
using System.Globalization;

namespace Class06
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde;
            Produto p;
            p = new Produto();

            Console.WriteLine("Digite os dados do produto : ");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qtde em Estoque: ");
            p.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a qtde de dprodutos que entraram: ");
            qtde = int.Parse(Console.ReadLine());
            p.RealizarEntrada(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a qtde de dprodutos que sairam: ");
            qtde = int.Parse(Console.ReadLine());
            p.RealizarSaida(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.ReadLine();
        }
    }
}
