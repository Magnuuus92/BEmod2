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
        Console.WriteLine($"You now have these items in your pockets:");
        foreach (var item in pockets.GetAll())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Do you want to test the key on the locked door?(y/n)");
        string? ans2 = Console.ReadLine();
        if (ans2 == "yes" || ans2 == "y")
        {
            Console.WriteLine("You put the small key into the lock of locked door.");
            Console.WriteLine("The door is now unlocked but the key is stuck in the lock.");
            pockets.Remove("small key");

        }
        else
        {
            Console.WriteLine("Your journey ends here");
        }
        Console.WriteLine("Now you remember why you wanted to open the locked door");
        Console.WriteLine("This is your home, its late and you are really tired.");
        Console.WriteLine("do you want to go and sleep in your bed? (y/n)");
        string? ans3 = Console.ReadLine();
        if (ans3 == "yes" || ans3 == "y")
        {
            Console.WriteLine("You fall asleep having stressful dreams about the busted lock on your front door.");
        }
        if (ans3 == "no" || ans3 == "n")
        {
            Console.WriteLine("What do you want to do instead? Here are your options:");
            Console.WriteLine("1: Watch Tv. 2:Rummage around the house for another key.");
            string? ans4 = Console.ReadLine();
            if (ans4 == "1")
            {
                Console.WriteLine("You watch Tv on your couch and fall asleep having stressful dreams about the busted lock on your front door.");
            }
            if (ans4 == "2")
            {

            }
        }


        /* keys.Add("Large key");
         Console.WriteLine($"Antall: {keys.Count}");
 */

    }
}