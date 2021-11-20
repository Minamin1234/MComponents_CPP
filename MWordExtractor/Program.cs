using System;

namespace MWordExtractor
{
    //For test program.
    class Program
    {
        static void Main(string[] args)
        {
            string words = "";
            Console.WriteLine("Hello World!");
            words = Console.ReadLine();
            Console.WriteLine("Word:");
            Console.WriteLine(WordExtractor.Search(ref words, "Hello"));
            Console.WriteLine("FirstIndex:");
            Console.WriteLine(WordExtractor.SearchFirstWrd(ref words, "Hello"));
        }
    }
}
