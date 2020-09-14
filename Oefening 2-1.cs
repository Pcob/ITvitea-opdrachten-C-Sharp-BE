using System;

namespace Csharp
{

    public class ExerciseOne
    {
        static public void First()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int intGetal1, intGetal2, intSom;

            Console.Write("Geef getal1: ");
            intGetal1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef getal2: ");
            intGetal2 = Convert.ToInt16(Console.ReadLine());

            intSom = intGetal1 + intGetal2;

            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("De som bedraagt: " + intSom.ToString());
            Console.ReadLine();
        }
    }
}


