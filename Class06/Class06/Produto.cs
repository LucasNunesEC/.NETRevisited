using System;
using System.Globalization;

namespace Class06
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public double ValorTotalEmEstoque() {
            return preco * quantidadeEmEstoque;
        }

        public void RealizarEntrada(int quantidade) {
            quantidadeEmEstoque += quantidade;
        }

        public void RealizarSaida(int quantidade) {
            quantidadeEmEstoque -= quantidade;
        }


        public override string ToString() {
            return nome
                + ", R$"
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades, Total:  R$: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
