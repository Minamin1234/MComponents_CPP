using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using MCommandComponent;

namespace Test_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string cmd = Console.ReadLine();
                List<string> Args = new List<string>(MCommandReader.GetArgs(cmd, ' '));
                foreach (var arg in Args)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
