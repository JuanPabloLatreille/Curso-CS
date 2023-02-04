using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(preco, quantidade);
            bool nomeValidacao = produto.isStringValid(nome);

            if (nomeValidacao)
            {
                produto.Nome = nome;
                Console.Write(produto);

                Console.WriteLine();
                Console.Write("Digite o numero de produtos a ser adicionados em estoque: ");
                produto.QuantidadeDigitada = int.Parse(Console.ReadLine());
                produto.AdicionarProdutos();
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + produto);
                Console.Write("Digite a quantidade de produtos que deseja remover do estoque: ");
                produto.QuantidadeDigitada = int.Parse(Console.ReadLine());
                produto.RemoverProdutos();
                Console.WriteLine("Dados atualizados: " + produto);
            }
            else
            {
                System.Console.WriteLine("Nome com tamanho inesperado");
            }
        }
    }
}