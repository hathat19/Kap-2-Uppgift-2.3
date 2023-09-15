using System;
namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar hur många dagar användaren ska låna bilen
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int days = int.Parse(Console.ReadLine());

            //Frågar hur många kilometer användaren ska köra
            Console.WriteLine("Hur många kilometer tänker du köra med bilen?");
            int kilometers = int.Parse(Console.ReadLine()); 

            //Räknar ut summan
            int sum = 300 + kilometers + 500*(days-1);

            //Skriver ut summan
            Console.WriteLine($"Det kostar totalt {sum}kr att hyra bilen.");
        }
    }
}