using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DataDoSistema = DateTime.Now;
            int dia = DateTime.Now.Day;
            int mês = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Neste momento é exatamente {DataDoSistema}");
            Console.WriteLine("ou");
            Console.WriteLine($"Dia {dia}, mês {mês}, ano {ano}, á exatamento {hora} horas, {minuto} minutos e {segundo} segundos.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
