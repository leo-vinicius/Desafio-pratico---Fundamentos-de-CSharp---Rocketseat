using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_prático___Fundamentos_de_C_Sharp;
public static class Nome
{
    public static void PedirNomeEExibir()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
    public static void ConcatenarNome()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome} {sobrenome}");
    }
}
