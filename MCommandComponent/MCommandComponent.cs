using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MCommandComponent
{
    public class Error : Exception
    {
        public Error() : base() { }
        public Error(string message) : base(message) { }
    }

    public static class MCommandReader
    {
        public static char SeparationChr = ' ';
        public static IEnumerable<string> GetArgs(string command,char sprtchr)
        {
            string cword = "";
            foreach (var chr in command)
            {
                if(chr == sprtchr)
                {
                    yield return cword;
                    cword = "";
                }
                else
                {
                    cword += chr;
                }
            }
            yield return cword;
        }

        public static IEnumerable<string> GetArgs(string command)
        {
            string cword = "";
            foreach (var chr in command)
            {
                if (chr == SeparationChr)
                {
                    yield return cword;
                    cword = "";
                }
                else
                {
                    cword += chr;
                }
            }
            yield return cword;
        }
    }

    public static class MCommandSearcher
    {

    }

    public class MCMDModule
    {
        public string ModuleName = "";
        public MCMDModule() { }
        public virtual bool ExecuteCommand(List<string> CArgs) { return true; }
    }
}
