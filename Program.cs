using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using IStore;
using Storage;

class Program
{
    static void Main()
    {
        IStore<string> pockets = new Storage<string>();
        pockets.Add("crumpled up old receipt");
        Console.WriteLine("You encounter a locked door");
        Console.WriteLine("Would you like to look for a key? (y/n)");
        string? ans1 = Console.ReadLine();
        if (ans1 == "y" || ans1 == "yes")
        {
            Console.WriteLine("You look for a key");
            Console.WriteLine("You found a small key");

        }
        else
        {
            Console.WriteLine("Your journey ends here");
        }

        pockets.Add("small key");
        Console.WriteLine($"You now have these items in your pocket {pockets.Get(0)}.");
        /* keys.Add("Large key");
         Console.WriteLine($"Antall: {keys.Count}");
 */

    }
}