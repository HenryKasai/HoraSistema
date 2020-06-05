using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DataDoSistema = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Neste momento são exatamente {DataDoSistema}.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
