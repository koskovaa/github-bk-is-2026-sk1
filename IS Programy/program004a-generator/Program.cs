string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("***************************************");
    Console.WriteLine("*** Generátor pseudonáhodných čísel ***");
    Console.WriteLine("***************************************");
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
        Console.Write("Nezadali jste celé číslo vetší než dolní mez. Zadejte horní mez znovu: ");
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

    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    // generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
       myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
       Console.Write($"{myRandNumbs[i]}; ");

    if(myRandNumbs[i] > 0)
        positiveNumbs++;
    if(myRandNumbs[i] < 0)
        negativeNumbs++;
    if(myRandNumbs[i] == 0)
        zeros++;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Počet kladných čísel: {positiveNumbs}");
    Console.WriteLine($"Počet záporných čísel: {negativeNumbs}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine("==========================");
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine();
    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}
