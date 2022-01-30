using System;

namespace AulaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "Danilo";

            switch (valor)
            {
                case "Danilo":
                    Console.WriteLine("Encontrou!");
                    break;
                case "José":
                    Console.WriteLine("Errou!");
                    break;
                case "João":
                    Console.WriteLine("Errou!");
                    break;
                default:
                    Console.WriteLine("Incorreto!");
                    break;
            }
        }
    }
}
