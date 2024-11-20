using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_prático___Fundamentos_de_C_Sharp;
public static class Data
{
    public static void SolicitarDados()
    {
        Console.WriteLine("Qual é o formato de data desejado?");   
        Console.WriteLine("1 - Formato completo.");   
        Console.WriteLine("2 - Apenas a data no formato dd/mm/aaaa.");   
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");   
        Console.WriteLine("4 - A data com o mês por extenso.");
        int n = int.Parse(Console.ReadLine());

        DataFormato(n);
    }

    public static void DataFormato(int n)
    {
        DateTime dataAtual = DateTime.Now;
        switch (n)
        {
            case 1:
                Console.WriteLine(dataAtual.ToString("dddd, d 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case 2:
                Console.WriteLine(dataAtual.ToString("d"));
                break;
            case 3:
                Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
                break;
            case 4:
                Console.WriteLine(dataAtual.ToString("d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Número digitado invállido.");
                break;
        }
    }
}
