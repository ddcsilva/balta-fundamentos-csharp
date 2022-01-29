using System;

namespace AulaUtilizandoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int maioridade = 18;

            if (idade >= maioridade)
            {
                System.Console.WriteLine("É maior de idade");
            }
            else
            {
                System.Console.WriteLine("É menor de idade");
            }

            System.Console.WriteLine("Finalizou o programa!");
        }
    }
}
