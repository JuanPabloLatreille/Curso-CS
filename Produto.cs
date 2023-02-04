using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Produto
{
    public string Nome { get; set; }
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto()
    {

    }

    public Produto(double preco, int quantidade)
    {
        Preco = preco;
        Quantidade = quantidade;
    }

    public bool isStringValid(string nome)
    {
        if (nome != null && nome.Length > 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public double valorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public int QuantidadeDigitada;

    public void AdicionarProdutos()
    {
        Quantidade = Quantidade + QuantidadeDigitada;
    }

    public void RemoverProdutos()
    {
        Quantidade = Quantidade - QuantidadeDigitada;
    }

    public override string ToString()
    {
        return "Dados do produto: " + Nome + ", " + "R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, " + "Total: R$ " + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }

    public override bool Equals(object? obj)
    {
        return obj is Produto produto &&
               Nome == produto.Nome;
    }
}