using System.Globalization;

namespace ExercicioAumentarSalario;

internal class Funcionario
{
    public string? Nome;
    public double SalarioBruto;
    public double Imposto;

    public double salarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += (SalarioBruto * porcentagem / 100.0);
    }

    public override string ToString()
    {
        return $"{Nome}, R$ {salarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}
