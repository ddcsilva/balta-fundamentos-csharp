using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            short resultado;

            Console.Clear();

            Console.WriteLine("Calculadora");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");

            Console.WriteLine("Selecione uma opção:");
            resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("Primeiro valor:");
            valor1 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("Segundo valor:");
            valor2 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("");

            resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.WriteLine("");

            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("Primeiro valor:");
            valor1 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("Segundo valor:");
            valor2 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("");

            resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.WriteLine("");

            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("Primeiro valor:");
            valor1 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("Segundo valor:");
            valor2 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("");

            resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.WriteLine("");

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("Primeiro valor:");
            valor1 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("Segundo valor:");
            valor2 = float.Parse(Console.ReadLine()); // ReadLine() RETORNA UMA STRING, NECESSITA DE CONVERSÃO

            Console.WriteLine("");

            resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.WriteLine("");

            Console.ReadKey();

            Menu();
        }
    }
}
