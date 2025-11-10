using IStore;
using Storage;

class Program
{
    static void Main()
    {
        IStore<string> stringstorage = new Storage<string>();
        stringstorage.Add("testing");
        stringstorage.Add("testing 2");
        Console.WriteLine($"Første element{stringstorage.Get(0)}");
        Console.WriteLine($"Antall: {stringstorage.Count}");


    }
}