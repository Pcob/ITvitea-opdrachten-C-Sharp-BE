using System;

namespace Csharp
{
  
    public class ExerciseThree
    {
        static public void Main()
        {
            int EUR, dol, intSom;

            Console.WriteLine("EURO's omrekenen naar dollars: ");
            Console.Write("Type het aantal EURO in: ");
            EUR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type aantal dollar in van 1,2231: ");
            dol = Convert.ToInt32(Console.ReadLine());

            intSom = EUR * dol;

            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("X EUR is gelijk aan Y USD: " + intSom.ToString());
            Console.ReadLine();

        }
    }
}
