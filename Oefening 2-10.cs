using System;
using System.ComponentModel;

namespace Csharp
{
  
    public class ExerciseTen
    {
        static void Main(string[] args)
        {
            int Inkoopprijs, intSom;
            double winstmarge;

            Console.WriteLine("Berekening van winstmarge op inkoopprijzen");
            Console.Write("Type inkoopprijs: ");
            Inkoopprijs = Convert.ToInt32(Console.ReadLine());
            winstmarge = 1.90;
           

            intSom = (Inkoopprijs * (int)winstmarge);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Winstmarge is: " + intSom.ToString());
            Console.ReadKey();
        }
    }
}
