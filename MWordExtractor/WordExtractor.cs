﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWordExtractor
{
    public static class WordExtractor
    {
        public static string Version = "v0.1";

        /// <summary>
        /// 完全に一致する単語があればTrueを返します。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="word"></param>
        /// <returns>同じ単語が見つかったかどうか</returns>
        public static bool Search(ref string target, string word)
        {
            bool frag = false;
            for(int i = 0;i < target.Length - 1;i++)
            {
                if(target[i] == word[0])
                {
                    for(int ii = 0;ii < word.Length -1;ii++)
                    {
                        frag = true;
                        if (target[i + ii] != word[ii])
                        {
                            if (i + ii > target.Length - 1) return false;
                            i += ii;
                            frag = false;
                            break;
                        }
                    }
                    if (frag) return true;
                }
            }
            return false ;
        }

        /// <summary>
        /// 合致した単語の最初のインデックスを返します。
        /// 合致する単語が無い場合は-1を返します。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="word"></param>
        /// <returns>最初に合致した文字列のインデックス.
        /// 合致しない場合には-1
        /// </returns>
        public static int SearchFirstWrd(ref string target,string word)
        {
            bool frag = false;
            for (int i = 0; i < target.Length - 1; i++)
            {
                if (target[i] == word[0])
                {
                    for (int ii = 0; ii < word.Length - 1; ii++)
                    {
                        frag = true;
                        if (target[i + ii] != word[ii])
                        {
                            if (i + ii > target.Length - 1) return -1;
                            i += ii;
                            frag = false;
                            break;
                        }
                    }
                    if (frag) return i;
                }
            }

            return -1;
        }
    }
}