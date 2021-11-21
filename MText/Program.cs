using System;

namespace MText
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = 'B';
            char c = '\0';
            char d = '\0';
            string sa = "Hello World";
            string sb = "hello world";
            string sc = "HELLO WORLD";
            string sd = "";
            string se = "";
            Console.WriteLine("Hello World!");
            Console.WriteLine(MText.IsLower(a));//true / 1
            Console.WriteLine(MText.IsLower(b));//false / 0
            Console.WriteLine(MText.IsUpper(a));//false / 0
            Console.WriteLine(MText.IsUpper(b));//true / 1
            Console.WriteLine(MText.IsUpper(sa));//false / 0
            Console.WriteLine(MText.IsUpper(sb));//false / 0
            Console.WriteLine(MText.IsUpper(sc));//true / 1
            /*Console.WriteLine(MText.IsLower(sa));//false / 0
            Console.WriteLine(MText.IsLower(sb));//true / 1
            Console.WriteLine(MText.IsLower(sc));//false / 0
            Console.WriteLine(MText.IsContainsUpper(sa));//true / 1
            Console.WriteLine(MText.IsContainsUpper(sb));//false / 0
            Console.WriteLine(MText.IsContainsUpper(sc));//true / 1
            Console.WriteLine(MText.IsContainsLower(sa));//true / 1
            Console.WriteLine(MText.IsContainsLower(sb));//true / 1
            Console.WriteLine(MText.IsContainsLower(sc));//false / 0
            Console.WriteLine(MText.ToUpper(a));//A
            Console.WriteLine(MText.ToUpper(b));//B
            Console.WriteLine(MText.ToLower(a));//a
            Console.WriteLine(MText.ToLower(b));//b
            Console.WriteLine(MText.ToUpper(sa));//HELLO WORLD
            Console.WriteLine(MText.ToUpper(sb));//HELLO WORLD
            Console.WriteLine(MText.ToUpper(sc));//HELLO WORLD
            Console.WriteLine(MText.ToLower(sa));//hello world
            Console.WriteLine(MText.ToLower(sb));//hello world
            Console.WriteLine(MText.ToLower(sc));//hello world
            Console.WriteLine(MText.ToLower(a,ref c));//true / 1
            Console.WriteLine(c);//a
            Console.WriteLine(MText.ToLower(b, ref c));//true / 1
            Console.WriteLine(c);//B
            Console.WriteLine(MText.ToLower(sa, ref sd));//true / 1
            Console.WriteLine(sd);//hello world
            Console.WriteLine(MText.ToLower(sb, ref sd));//true / 1
            Console.WriteLine(sd);//hello world
            Console.WriteLine(MText.ToLower(sc, ref sd));//true / 1
            Console.WriteLine(sd);//hello world
            Console.WriteLine(MText.ToUpper(sa, ref sd));//true / 1
            Console.WriteLine(sd);//HELLO WORLD
            Console.WriteLine(MText.ToUpper(sb, ref sd));//true / 1
            Console.WriteLine(sd);//HELLO WORLD
            Console.WriteLine(MText.ToUpper(sc, ref sd));//true / 1
            Console.WriteLine(sd);//HELLO WORLD*/
        }
    }
}
