using System;
using System.Globalization;

namespace class_2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque()
        {
            double value = 0.0;
            value = Preco * Quantidade;

            return value;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return "Dados do produto: " + Nome 
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
