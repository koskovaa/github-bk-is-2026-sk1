string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("**************************");
    Console.WriteLine("******* Výpis řady *******");
    Console.WriteLine("**************************");
    Console.WriteLine();

    //Vstup počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo):");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
    }

    Console.Write("Zadejte poslední číslo řady (celé číslo):");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last)) {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu:");
    }

    Console.Write("Zadejte diferenci řady ( kladné celé číslo):");
    int step;
        while(!int.TryParse(Console.ReadLine(), out step) || step <= 0) {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci řady znovu:");
    }

    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"První číslo: {first}");
    Console.WriteLine($"Poslední číslo: {last}");
    Console.WriteLine($"Diference (step): {step}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();

    // výpis řady
    Console.WriteLine("Výpis číselné řady:");
    Console.WriteLine();
    if(first <= last)
    {
        int current = first;
        while(current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat vzestupnou řadu.");
    }

    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}