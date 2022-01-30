using System;

namespace AulaGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);

            id = new Guid("045a0c03-eb69-4152-8b3b-35ee3a1c7d3d");
            Console.WriteLine(id);

            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
