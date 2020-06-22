using System;

namespace Aula22Senai
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Valor em Reais  " + Conversor.DolartoReal(15));
        
        Console.WriteLine("Valor em Dolar " + Conversor.RealtoDolar(15));
        Console.WriteLine("Valor em Euro " +Conversor.RealtoEuro(15));
        Console.WriteLine("Valor em reais " + Conversor. EurotoReal(15));
        }
    }
}
