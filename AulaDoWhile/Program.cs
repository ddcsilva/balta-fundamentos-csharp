﻿using System;

namespace AulaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            do
            {
                Console.WriteLine(valor);
                valor++;
            }
            while (valor <= 5);
        }
    }
}
