string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("**************************************");
    Console.WriteLine("******* Vykreslování obdelníku *******");
    Console.WriteLine("**************************************");
    Console.WriteLine();

    // načtení šířky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte šířku znovu: ");
        Console.ResetColor();
    }

    // načtení výšky
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }
    
    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Šířka: {width}");
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();

    // vykreslení obdelníku
    // vnější cyklus, který bude hlídat počet řádků (shora dolů)
    for(int i = 1; i <= height; i ++)
    {
        if ( i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
      // vnitřní cyklus
      for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // zpoždění
        }
        Console.WriteLine();
    }
    Console.ResetColor();

    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou bude program ukončen.");
    again = Console.ReadLine() ?? "";
}

