using System;

namespace AulaNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? idade = null;
            System.Console.WriteLine(idade);
            idade = 0;
            idade = 25;
        }
    }
}
