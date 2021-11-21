using System;

namespace MText
{
    class Program
    {
        static void Main(string[] args)
        {
            char ca = 'a';
            char cb = 'A';
            string sa = "Hea llo";
            string sb = "he llo";
            Console.WriteLine("Hello World!");
            Console.WriteLine(MText.IsEqual(ca, cb));//True
            Console.WriteLine(MText.IsEqual(sa, sb));//True
            ca = 'b';
            sa = "ggga";
            Console.WriteLine(MText.IsEqual(ca, cb));//False
            Console.WriteLine(MText.IsEqual(sa, sb));//False
        }
    }
}
