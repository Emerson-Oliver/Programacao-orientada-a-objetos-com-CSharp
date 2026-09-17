using System.Globalization;

namespace ControleEstoque;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preco: ");
        produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dados do produto: {produto} \n");

        Console.Write("Digite a quantidade de proddutos a serem adicionado ao estoque: ");
        int qtde = int.Parse(Console.ReadLine());
        produto.AdicionarProduto(qtde);
        Console.WriteLine();
        Console.WriteLine($"Dados Atualizados: {produto}");

        Console.Write("Digite a quantidade de proddutos a serem removidos do estoque: ");
        qtde = int.Parse(Console.ReadLine());
        produto.RemoverProduto(qtde);
        Console.WriteLine();
        Console.WriteLine($"Dados Atualizados: {produto}");

        Console.ReadKey();
    }
}