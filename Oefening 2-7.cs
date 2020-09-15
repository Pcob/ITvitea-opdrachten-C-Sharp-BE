using System;

namespace Csharp
{
  
    public class ExerciseSeven
    {
        static public void Main()
        {
            int a, b, c, intSom;

            Console.WriteLine("Berekeningen maken: ");
            Console.Write("Type een getal in: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type een 2e getal in: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type een 3e getal in: ");
            c = Convert.ToInt32(Console.ReadLine());

           

            intSom = a * (b/c);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Het totaal is: " + intSom.ToString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
