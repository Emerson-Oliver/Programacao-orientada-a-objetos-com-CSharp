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

        Console.WriteLine($"Dados do produto: {produto}");

        Console.ReadKey();
    }
}