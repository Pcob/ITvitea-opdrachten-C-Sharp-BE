using System;

namespace Csharp
{
  
    public class ExerciseNine
    {
        static public void Main()
        {


            Console.WriteLine("Geef uw adres gegevens op: ");
            Console.Write("Uw voornaam: ");
            String voornaam = Console.ReadLine();
            Console.Write("Uw achternaam: ");
            String achternaam = Console.ReadLine();
            Console.Write("Uw straat: ");
            String straat = Console.ReadLine();
            Console.Write("Uw huisnummer: ");
            String huisnummer = Console.ReadLine();
            Console.Write("Uw postcode: ");
            String postcode = Console.ReadLine();
            Console.Write("Uw gemeente: ");
            String gemeente = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Dit zijn uw adresgegevens: " +
                                    "" +
                                     voornaam +
                                    " "
                                    + achternaam +
                                    " "
                                    + straat +
                                    " "
                                    + huisnummer +
                                    " "
                                    + postcode +
                                    " "
                                    + gemeente +
                                    " "
                                    );
            Console.ReadKey();
            Console.Clear();
        }
    }
}
