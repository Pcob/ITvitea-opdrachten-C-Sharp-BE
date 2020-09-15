using System;

namespace Csharp
{
  
    public class ExerciseFive
    {
        static public void Main()
        {
            int AmountFr, AmountKon, AmountIJs, AmountDra, intSom;

            Console.WriteLine("Prijs van frietjes is 20 EUR: ");
            Console.Write("Type het aantal frietjes in: ");
            AmountFr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs koninginnehapje is 10 EUR: ");
            Console.Write("Type het aantal koninginnehapjes in: ");
            AmountKon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs ijsje is 3 EUR: ");
            Console.Write("Type het aantal ijsjes in: ");
            AmountIJs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs van drankje is 2 EUR: ");
            Console.Write("Type het aantal drankjes in: ");
            AmountDra = Convert.ToInt32(Console.ReadLine());

            intSom = (AmountFr * 20) + (AmountKon * 10) + (AmountIJs * 3) + (AmountDra * 2);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
            Console.ReadKey();
        }
    }
}
