using System;
namespace Uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int svar = int.Parse(Console.ReadLine());
            int[] tal = new int[svar];
            for (int i = 0; i < svar; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < svar; i++)
            {
                Console.WriteLine("Den tal är:");
                int nummer;
                nummer = i + 1;
                Console.WriteLine("tal" + nummer + ": "+tal[i] + "");
            }
        }
    }
}