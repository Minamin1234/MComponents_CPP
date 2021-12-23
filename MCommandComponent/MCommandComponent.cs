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
        public static char CMDSeparationChr = ' ';
        public static char SeparationChr = ',';
        public static string DefaultBlockStr = "()";

        /// <summary>
        /// 指定した「区切り文字」にて区切られた引数をリストで返します。
        /// </summary>
        /// <param name="command">「区切り文字」で区切られたコマンド</param>
        /// <param name="sprtchr">区切り文字</param>
        /// <returns>区切り文字を除いた引数値のリスト</returns>
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

        /// <summary>
        /// 本クラス変数にて指定した「区切り文字」にて区切られた引数をリストで返します。
        /// </summary>
        /// <param name="command">「区切り文字」で区切られたコマンド</param>
        /// <returns>区切り文字を除いた引数値のリスト</returns>
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

        /// <summary>
        /// 指定した「囲い文字」で囲まれた引数を全て取り出し、返します。
        /// 「区切り文字」が含まれていてもそのまま返されます。
        /// 最初の「囲い文字」が含まれるまで、直前の文字は取り出しません。
        /// </summary>
        /// <param name="command">「囲い文字が含まれる文字列」</param>
        /// <param name="blocktype">「囲い文字」の種類</param>
        /// <returns>「囲い文字」の中に含まれる文字列</returns>
        public static string GetValueInBlock(string command,string blocktype)
        {
            string carg = "";
            bool frag = false;
            foreach(var chr in command)
            {
                if (chr == blocktype[0]) frag = true;
                if (chr == blocktype[1]) frag = false;
                if (frag)
                {
                    if(chr != blocktype[0] && chr != blocktype[1]) carg += chr;
                }
            }
            return carg;
        }

        /// <summary>
        /// クラス変数にて設定された「囲い文字」の中身を全て文字列で返します。
        /// 「区切り文字」が含まれていてもそのまま返されます。
        /// 最初の「囲い文字」が含まれるまで、直前の文字は取り出しません。
        /// </summary>
        /// <param name="command">「囲い文字が含まれる文字列」</param>
        /// <returns>「囲い文字」の中に含まれる文字列</returns>
        public static string GetValueInBlock(string command)
        {
            string carg = "";
            bool frag = false;
            foreach(var chr in command)
            {
                if(chr == DefaultBlockStr[0]) frag = true;
                if(chr == DefaultBlockStr[1]) frag = false;
                if (frag)
                {
                    if (chr != DefaultBlockStr[0] && chr != DefaultBlockStr[1]) carg += chr;
                }
            }
            return carg;
        }

        /// <summary>
        /// 「囲い文字」の中に含まれる「区切り文字」で区切られた文字列のリストを返します。
        /// </summary>
        /// <param name="command">「囲い文字」で囲まれた「区切り文字」が含まれる文字列</param>
        /// <returns>「区切り文字」で区切られた文字列のリスト</returns>
        public static IEnumerable<string> GetArgsInBlock(string command)
        {
            string carg = "";
            bool frag = false;
            foreach(var chr in command)
            {
                if (chr == DefaultBlockStr[0]) frag = true;
                if (chr == DefaultBlockStr[1]) frag = false;
                if(frag)
                {
                    if(chr == SeparationChr)
                    {
                        yield return carg;
                        carg = "";
                    }
                    else
                    {
                        if(chr != DefaultBlockStr[0] && 
                            chr != DefaultBlockStr[1] &&
                            chr != SeparationChr) carg += chr;
                    }
                }
            }
            yield return carg;
        }

        /// <summary>
        /// 指定した「囲い文字」の中に含まれる指定した「区切り文字」で区切られた文字列のリストを返します。
        /// </summary>
        /// <param name="command">「囲い文字」で囲まれた「区切り文字」が含まれる文字列</param>
        /// <param name="blocktype">「囲い文字」</param>
        /// <param name="sprtchr">「区切り文字」</param>
        /// <returns>「区切り文字」で区切られた文字列のリスト</returns>
        public static IEnumerable<string> GetArgsInBlock(string command,string blocktype,char sprtchr)
        {
            string carg = "";
            bool frag = false;
            foreach(var chr in command)
            {
                if( chr == blocktype[0]) frag = true;
                if( chr == blocktype[1]) frag = false;
                if(frag)
                {
                    if (chr == sprtchr)
                    {
                        yield return carg;
                        carg = "";
                    }
                    else
                    {
                        if(chr != blocktype[0] && 
                            chr != blocktype[1] && 
                            chr != sprtchr) carg += chr;
                    }
                }
            }
            yield return carg;
        }

        /// <summary>
        /// 囲み開始文字Aと囲み終了文字Bの間にある文字列を返します。
        /// </summary>
        /// <param name="command">「囲み文字」の含まれる文字列</param>
        /// <param name="A">囲い開始文字</param>
        /// <param name="B">囲い終了文字</param>
        /// <returns>囲み文字の間に含まれる文字列</returns>
        public static string GetStrInAtoB(string command,char A,char B)
        {
            bool frag = false;
            string carg = "";
            foreach(var chr in command)
            {
                if(chr == A) frag = true;
                if(chr == B) frag = false;
                if(frag)
                {
                    carg += chr;
                }
            }
            return carg;
        }

        /// <summary>
        /// 文字列の先頭から指定した文字までの間に含まれる文字列を返します。
        /// </summary>
        /// <param name="command">指定文字が含まれる文字列</param>
        /// <param name="A">取り出したい文字列の終端</param>
        /// <returns>指定した文字までの文字列</returns>
        public static string GetStrUntilA(string command,char A)
        {
            string cstr = "";
            foreach(var chr in command)
            {
                if (chr == A) break;
                cstr += chr;
            }
            return cstr;
        }
    }

    public class MCMDApp
    {
        public List<MCMDModule> Modules = new List<MCMDModule>();
        public MCMDApp() { }
        public bool Execute()
        {
            return true;
        }

        protected virtual int SearchModule(string name)
        {
            return 1;
        }
        protected virtual bool ExecuteCommand(string command)
        {

            return true;
        }
    }

    public class MCMDModule
    {
        public string ModuleName = "";
        public List<string> Commands = new List<string>();
        public MCMDModule() { this.Initialize(); }
        public void AddCommand(string cmd)
        {
            this.Commands.Add(cmd); 
        }
        public void AddCommand(string[] cmd)
        {
            foreach (var itm in cmd)
            {
                this.Commands.Add(itm);
            }
        }
        public void AddCommand(List<string> cmds)
        {
            foreach (var itm in cmds)
            {
                this.Commands.Add(itm);
            }
        }
        public void SetNewCommandList(string[] cmds)
        {
            this.Commands = new List<string>(cmds);
        }
        public void SetNewCommandList(List<string> cmds)
        {
            this.Commands = new List<string>(cmds);
        }
        public virtual void Initialize()
        {

        }
        public virtual bool ExecuteCommand(string Command,List<string> CArgs)
        {
            return true;
        }
    }
}
