using System;

namespace ControleProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine($"Dados atualizados {p}");

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine($"Dados atualizados {p}");

            Console.WriteLine("teste");
            Console.WriteLine("teste");
            Console.WriteLine("teste");

        }
    }
}