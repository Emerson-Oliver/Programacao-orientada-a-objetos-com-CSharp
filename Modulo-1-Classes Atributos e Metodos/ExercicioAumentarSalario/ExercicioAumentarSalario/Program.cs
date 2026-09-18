using System.Globalization;

namespace ExercicioAumentarSalario;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Funcioanrio: {funcionario}");
        Console.Write("Digite a porcentagem para aumentar o salario: ");
        double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(aumento);
        Console.WriteLine($"Dados atualizados: {funcionario}");
    }
}