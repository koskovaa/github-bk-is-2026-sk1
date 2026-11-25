string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("************************************");
    Console.WriteLine("*** Generátor - max, min, hodiny ***");
    Console.WriteLine("************************************");
    Console.WriteLine();

    //Vstup počáteční hodnoty
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet čísel znovu: ");
        Console.ResetColor();
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
        Console.ResetColor();
    }

    Console.Write("Zadejte horní mez (celé číslo vetší než dolní mez): ");
    int upperBound;
        while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo vetší nez dolní mez. Zadejte horní mez znovu: ");
        Console.ResetColor();
    }

    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Počet: {n}");
    Console.WriteLine($"Dolní mez: {lowerBound}");
    Console.WriteLine($"Horní mez: {upperBound}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();

    // zde budeme vkládat algoritmy

    // deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];

    // incializace generátoru náhodných čísel
    Random myRandNumb = new Random();

    // generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
       myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
       Console.Write($"{myRandNumbs[i]}; ");
    }

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    for(int i = 1 ; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("==========================");
    Console.WriteLine();

    if (max >= 3)
    {
       for(int i = 0; i < max ; i++)
        {
            int spaces = 0;
            int stars = 0;
            if(i < max / 2)
            {
                spaces = i;
                stars = max - (2 * i);
            }
            else
            {
                
            }

            for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }

            for(int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    else
    {
        Console.WriteLine("Maximum je menší než 3. Obrazec se nevykreslí.");
    }

    Console.WriteLine();
    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}