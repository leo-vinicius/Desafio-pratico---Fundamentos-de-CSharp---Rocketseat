using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_prático___Fundamentos_de_C_Sharp;
public static class OperacoesNumeros
{
    public static void SolicitarNumeros()
    {
        Console.WriteLine("Digite o primeiro número:");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double n2 = double.Parse(Console.ReadLine());

        Operacoes(n1, n2);
    }
    public static void Operacoes(double n1, double n2)
    {
        double soma = n1 + n2;
        double subtracao = n1 - n2;
        double multiplicacao = n1 * n2;
        double divisao = n2 != 0 ? n1 / n2 : double.NaN;

        double media = (n1 + n2) / 2;

        ImprimirDados(soma, subtracao, multiplicacao, divisao, media);
    }

    public static void ImprimirDados(double soma, double subtracao, double multiplicacao, double divisao, double media)
    {
        Console.WriteLine($"A soma dos números é: {soma}");
        Console.WriteLine($"A subtração dos números é: {subtracao}");
        Console.WriteLine($"A multiplicãção dos números é: {multiplicacao}");

        if (!double.IsNaN(divisao))
        {
            Console.WriteLine($"A divisão dos números é: {divisao:F2}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir números por 0.");
        }

        Console.WriteLine($"A media dos números é: {media}");
    }
}
