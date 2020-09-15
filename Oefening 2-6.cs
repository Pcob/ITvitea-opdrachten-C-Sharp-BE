using System;

namespace Csharp
{
  
    public class ExerciseSix
    {
        static public void Main()
        {
            int AmountVol, AmountKin, intSom;

            Console.WriteLine("Prijs Plopsaland voor volwassenen is 25 EUR: ");
            Console.Write("Type aantal volwassenen: ");
            AmountVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs Plopsaland voor kinderen t/m 12 jaar is 10 EUR: ");
            Console.Write("Type het aantal kinderen: ");
            AmountKin = Convert.ToInt32(Console.ReadLine());
           

            intSom = (AmountVol * 25) + (AmountKin * 10);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
            Console.ReadKey();
        }
    }
}
