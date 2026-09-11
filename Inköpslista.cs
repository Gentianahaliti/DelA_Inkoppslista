using System;
// Det här är som att öppna en verktygslåda som innehåller allt grundläggande i C#.
// Utan den kan jag inte skriva ut text eller läsa in text från användaren.

using System.Collections.Generic;
// Detta öppnar en extra verktygslåda som innehåller Listor.
// Listor är som flexibla lådor där jag kan lägga in saker och ta bort saker.
// Detta behöver jag för att kunna skapa List<string> och List<int>.

class InkopsLista
// En klass är som en behållare där jag lägger all kod som hör ihop.
// Här ligger hela mitt program.
{
    static void Main()
    // Detta är startpunkten. När jag kör programmet börjar C# här.
    {
        List<string> names = new List<string>();
        // En lista som håller text. Här sparar jag varunamnen: "Mjölk", "Bröd", "Ost".
        // Varje vara har samma index i båda listorna.
        // Index betyder "platsen i listan". Listor börjar alltid på 0.
        // Det betyder: names[0] och prices[0] hör ihop som två kolumner i ett Excel-ark.

        List<int> prices = new List<int>();
        // En lista som håller heltal. Här sparar jag priserna: 15, 32, 89.
        // Exempel: names[0] = "Mjölk" och prices[0] = 15 är samma vara.

        while (true)
        // “Så länge programmet är igång, fortsätt fråga användaren och uppdatera listan.”
        // Det är som ett spel som aldrig slutar förrän jag skriver “exit”.
        {
            Console.Clear();
            // Rensar terminalen så det inte blir rörigt.

            VisaLista(names, prices);
            // Anropar en metod som skriver ut hela listan + totalsumman.
            // Det är som att säga: "Visa mig hur listan ser ut nu."

            Console.Write("\nSkriv varunamn eller nummer (eller 'exit'): ");
            // Programmet skriver en fråga till användaren.

            string input = Console.ReadLine() ?? "";
            // Det användaren skriver sparas i variabeln input.
            // Om ingen text läses in används en tom text.

            if (input.ToLower() == "exit")
                break;
            // Hoppar ut ur loopen → Programmet avslutas.
            // Som att säga "Okej vi slutar nu".

            if (int.TryParse(input, out int nummer))
            // TryParse försöker göra om text till ett heltal.
            {
                TaBortVara(nummer, names, prices);
                // Om det lyckas → användaren skrev ett nummer → ta bort vara.
            }
            else
            {
                LäggTillVara(input, names, prices);
                // Om det misslyckas → användaren skrev ett namn → lägg till vara.
            }
        }
    }

    static void LäggTillVara(string namn, List<string> names, List<int> prices)
    // Den här metoden lägger till en ny vara i listan.
    // namn = det användaren skrev (t.ex. "Mjölk")
    // names = listan med varunamn
    // prices = listan med priser
    {
        Console.Write("Skriv pris för varan: ");
        // Programmet frågar användaren vad varan kostar.

        string prisText = Console.ReadLine() ?? "";
        // Läser in priset som text. Om inget skrivs → tom text.

        if (int.TryParse(prisText, out int pris))
        // TryParse försöker göra om texten till ett heltal.
        {
            names.Add(namn);
            // Lägger till varunamnet i listan.

            prices.Add(pris);
            // Lägger till priset i listan.

            Console.WriteLine("Vara tillagd!");
            // Bekräftelse till användaren.
        }
        else
        {
            Console.WriteLine("Fel: pris måste vara ett nummer.");
            // Om TryParse misslyckas → användaren skrev något som inte är ett nummer.
        }

        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
        Console.ReadKey();
        // En liten paus så användaren hinner läsa texten.
    }
     static void TaBortVara(int nummer, List<string> names, List<int> prices)
    // Den här metoden tar bort en vara från listan.
    {if (nummer >= 0 && nummer < names.Count)
        {
            names.RemoveAt(nummer);
            // Tar bort varunamnet.

            prices.RemoveAt(nummer);
            // Tar bort priset på samma plats.
        }
        else
        {
            {
            Console.WriteLine("Ogiltigt nummer!");
            // Om numret inte finns → felmeddelande.

            Console.ReadKey();
            // Paus så användaren hinner läsa.
        }
    }
            