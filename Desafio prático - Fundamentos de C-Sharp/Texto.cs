using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_prático___Fundamentos_de_C_Sharp;
public static class Texto
{
    public static void SolicitarDados()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string texto = Console.ReadLine();

        ContarCaracteres(texto);
    }

    public static void ContarCaracteres(string texto)
    {
        int caracteres = 0;
        for(int i = 0; i < texto.Length; i++)
        {
            if(!texto[i].Equals(' '))
            {
                caracteres++;
            }
        }
        Console.WriteLine($"A quantidade de caracteres é de: {caracteres}");
    }
}
