using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string entrada; 
            double Milhas, Km;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Entre com a medida (em milhas): ");

            Console.ForegroundColor = ConsoleColor.White;
            entrada = Console.ReadLine();
            Milhas = Convert.ToDouble(entrada);
            
            Km = Milhas * 1609;

            Console.Write($"{Km}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" km");

            Console.ResetColor();

        }
    }
}
