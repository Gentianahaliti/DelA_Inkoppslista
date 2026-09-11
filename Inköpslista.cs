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
        // Varje vara har samma index i båda listorna.// Index betyder "platsen i listan". Listor börjar alltid på 0.
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
        // Jag skriver ut en fråga till användaren.
        
