string again = "a";

// Řídící cyklus programu
while(again.ToLower() == "a" )
{
    


    // dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}