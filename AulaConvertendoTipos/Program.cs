using System;

namespace AulaConvertendoTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            // inteiro = real; // ERRO
            // inteiro = (int)real; // FUNCIONA
            // inteiro = int.Parse(real.ToString()); // ERRO
            // inteiro = int.Parse("150"); // FUNCIONA
            // inteiro = Convert.ToInt32(real); // FUNCIONA

            System.Console.WriteLine(inteiro);
            System.Console.WriteLine(real);
            System.Console.WriteLine(Convert.ToBoolean(1));
        }
    }
}
