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
    Console.Write("Zadejte číslo:");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
    }

    Console.Write("Zadejte další číslo:");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb)) {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu:");
    }

    Console.Write("Zadejte další číslo:");
    int ccc;
        while(!int.TryParse(Console.ReadLine(), out ccc) || ccc <= 0) {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci řady znovu:");
    }

    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"První číslo: {aaa}");
    Console.WriteLine($"Poslední číslo: {bbb}");
    Console.WriteLine($"Diference (step): {ccc}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();

    // zde budeme vkládat algoritmy

    // výpis řady
    Console.WriteLine("Výpis číselné řady:");
    Console.WriteLine();
    if(aaa <= bbb)
    {
        int current = aaa;
        while(current <= bbb)
        {
            Console.WriteLine(current);
            current += ccc;
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
