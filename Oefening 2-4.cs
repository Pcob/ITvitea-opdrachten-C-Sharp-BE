using System;

namespace Csharp
{
  
    public class ExerciseFour
    {
        static public void Main()
        {
            int EUR, btw, intSom;

            Console.WriteLine("Prijs met BTW berekenen: ");
            Console.Write("Prijs exclusief BTW: ");
            EUR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type het btw tarief van 21%. Het getal moet 1.21 zijn: ");
            btw = Convert.ToInt32(Console.ReadLine());

            intSom = EUR * btw;

            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Prijs inclusief btw is: " + intSom.ToString());
            Console.ReadLine();

        }
    }
}
