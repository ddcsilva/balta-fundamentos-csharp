using System;
using System.Threading;

namespace ProjetoStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string result = Console.ReadLine().ToLower();
            char type = char.Parse(result.Substring(result.Length - 1, 1));
            int time = int.Parse(result.Substring(0, result.Length - 1));
            int multiplier = 1;

            if (time == 0)
                Environment.Exit(0);

            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
