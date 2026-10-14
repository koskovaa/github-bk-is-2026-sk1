string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("**************************");
    Console.WriteLine("******* Výpis řady *******");
    Console.WriteLine("**************************");


    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}