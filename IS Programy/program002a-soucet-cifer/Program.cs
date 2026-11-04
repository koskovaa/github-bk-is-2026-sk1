string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("**************************");
    Console.WriteLine("***** Ciferný součin *****");
    Console.WriteLine("**************************");
    Console.WriteLine();

    //Vstup počáteční hodnoty
    Console.Write("Zadejte číslo:");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
    }

    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();

    // zde budeme vkládat algoritmy

    // příprava pomocných promněnných
    int numberBackup = number;
    int sum = 1; // neutrální hodnota pro sčítání je 0
    int digit;  // proměnná pro uložení právě zjištěné číslice

    // ošetření záporných čísel
    if(number < 0)
        number = -number;
    
    // zvláštní případ pro nulu
    if (number == 0)
        sum = 0;
    
    else
    {
        Console.WriteLine("Průběh rozkladu čísla na číslice:");
        Console.WriteLine();

        // matematický rozklad čísla pomocí cyklu
        while (number > 0)
        {
            digit = number % 10; // modulo -> získáme poslední číslici
            sum *= digit;
            Console.WriteLine($"Získaná číslice: {digit}");

            number /= 10; // celočíselné dělení
        }
    }

    // výpis výsledků
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Součin cifer čísla {numberBackup} je {sum}.");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();


    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}

