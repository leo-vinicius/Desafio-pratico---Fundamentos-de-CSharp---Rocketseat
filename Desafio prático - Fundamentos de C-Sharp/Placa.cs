using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_prático___Fundamentos_de_C_Sharp;
public static class Placa
{
    public static void SolicitarDados()
    {
        Console.WriteLine("Digite uma placa:");
        string placa = Console.ReadLine();
        
        VerificaPlaca(placa);
    }

    public static void VerificaPlaca(string placa)
    {
        bool verificador = true;
        if(placa is null || placa.Length != 7)
        {
            verificador = false;
            Console.WriteLine(verificador);
            return;
        }

        for(int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                verificador = false;
                Console.WriteLine(verificador);
                return;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                verificador = false;
                Console.WriteLine(verificador);
                return;
            }
        }

        Console.WriteLine(verificador);
        return;
    }
}
