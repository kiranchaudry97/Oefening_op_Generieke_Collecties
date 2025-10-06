// See https://aka.ms/new-console-template for more information
using Oefening_op_Generieke_Collecties;


public partial class Program
{
    public static void Main()
    {
        // Test met integers
        Stapel<int> intStapel = new Stapel<int>();
        intStapel.Opzetten(10);
        intStapel.Opzetten(20);
        intStapel.Opzetten(30);
        Console.WriteLine("Integer-stapel:");
        Console.WriteLine(intStapel);

        Console.WriteLine($"Afhalen: {intStapel.Afhalen()}");
        Console.WriteLine(intStapel);

        // Test met strings
        Stapel<string> stringStapel = new Stapel<string>();
        stringStapel.Opzetten("Appel");
        stringStapel.Opzetten("Banaan");
        stringStapel.Opzetten("Kers");
        Console.WriteLine("\nString-stapel:");
        Console.WriteLine(stringStapel);

        // Test met eigen klasse
        Stapel<Persoon> persoonStapel = new Stapel<Persoon>();
        persoonStapel.Opzetten(new Persoon("Alice", 25));
        persoonStapel.Opzetten(new Persoon("Bob", 30));
        persoonStapel.Opzetten(new Persoon("Charlie", 35));
        Console.WriteLine("\nPersoon-stapel:");
        Console.WriteLine(persoonStapel);
    }
}
