using System;

namespace AulaComparacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));

            Console.WriteLine(texto.Contains("Test"));
            Console.WriteLine(texto.Contains("test"));
            Console.WriteLine(texto.Contains("test", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
