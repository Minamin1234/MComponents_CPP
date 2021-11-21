using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MText
{
    public static class MText
    {
        public static int UpLowerConstant = 'z' - 'A';
        /// <summary>
        /// 指定した文字が大文字であるかどうかを返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>大文字であるかどうか</returns>
        public static bool IsUpper(char target)
        {
            if (target >= 'A' && target <= 'Z') return true;
            return false;
        }

        /// <summary>
        /// 指定した文字が小文字であるかどうかを返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>小文字であるかどうか</returns>
        public static bool IsLower(char target)
        {
            if (target >= 'a' && target <= 'z') return true;
            return false;
        }

        /// <summary>
        /// 小文字から大文字に変換します。「文字」でない場合、ヌル文字を返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>大文字にした文字</returns>
        public static char ToUpper(char target)
        {
            if (target >= 'a' && target <= 'z') return (char)(target - UpLowerConstant);
            if (target >= 'A' && target <= 'Z') return target;
            return '\0';
        }

        /// <summary>
        /// 大文字から小文字に変換します。「文字」でない場合、ヌル文字を返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>小文字にした文字</returns>
        public static char ToLower(char target)
        {
            if (target >= 'A' && target <= 'Z') return (char)(target + UpLowerConstant);
            if (target >= 'a' && target <= 'z') return target;
            return '\0';
        }

        /// <summary>
        /// 指定した文字を大文字に変換して格納します。「文字」でない場合、ヌル文字が格納されます。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="c"></param>
        /// <returns>変換に成功したかどうか</returns>
        public static bool ToUpper(char target,ref char c)
        {
            if (target >= 'a' && target <= 'z')
            {
                c = (char)(target - UpLowerConstant);
                return true;
            }
            if(target >= 'A' && target <= 'Z')
            {
                c = target;
                return true;
            }
            c = '\0';
            return false;
        }

        /// <summary>
        /// 指定した文字を小文字に変換して格納します。「文字」でない場合、ヌル文字が格納されます。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="c"></param>
        /// <returns>変換に成功したかどうか</returns>
        public static bool ToLower(char target,ref char c)
        {
            if(target >= 'A' && target <= 'Z')
            {
                c = (char)(target + UpLowerConstant);
                return true;
            }
            if (target >= 'a' && target <= 'z')
            {
                c = target;
                return true;
            }
            c = '\0';
            return false;
        }

        /// <summary>
        /// 指定した文字列が全て大文字かどうかを返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>大文字かどうか</returns>
        public static bool IsUpper(string target)
        {
            foreach(var s in target)
            {
                if (s >= 'A' && s <= 'Z') continue;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 指定した文字列に大文字が含まれるかどうかを返します。
        /// 含まれていない場合は-1を返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>大文字が含まれるかどうか。含まれない場合は-1</returns>
        public static bool IsContainsUpper(string target)
        {
            foreach(var s in target)
            {
                if (s >= 'A' && s <= 'Z') return true;
            }
            return false;
        }

        /// <summary>
        /// 指定した文字列が全て小文字かどうかを返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>小文字かどうか</returns>
        public static bool IsLower(string target)
        {
            foreach(var s in target)
            {
                if (s >= 'a' && s <= 'z') continue;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 指定した文字列に小文字が含まれるかどうかを返します。
        /// 含まれない場合は-1を返します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>小文字が含まれるかどうか。含まれない場合は-1</returns>
        public static bool IsContainsLower(string target)
        {
            foreach(var s in target)
            {
                if (s >= 'a' && s <= 'z') return true;
            }
            return false;
        }

        /// <summary>
        /// 指定した文字列を大文字に変換します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>変換した文字列</returns>
        public static string ToUpper(string target)
        {
            string ntarget = "";
            for(int i = 0;i < target.Length;i++)
            {
                if (target[i] >= 'a' && target[i] <= 'z') ntarget += (char)(target[i] - UpLowerConstant);
                else ntarget += target[i];
            }
            return ntarget;
        }

        /// <summary>
        /// 指定した文字列を小文字に変換します。
        /// </summary>
        /// <param name="target"></param>
        /// <returns>変換した文字列</returns>
        public static string ToLower(string target)
        {
            string ntarget = "";
            for(int i = 0; i < target.Length;i++)
            {
                if (target[i] >= 'A' && target[i] <= 'Z') ntarget += (char)(target[i] + UpLowerConstant);
                else ntarget += target[i];
            }
            return ntarget;
        }

        /// <summary>
        /// 指定した文字列を全て大文字に変換し、格納します。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="nstr"></param>
        /// <returns>変換に成功したかどうか</returns>
        public static bool ToUpper(string target,ref string nstr)
        {
            string ntarget = "";
            for(int i = 0;i < target.Length;i++)
            {
                if (target[i] >= 'a' && target[i] <= 'z') ntarget += (char)(target[i] - UpLowerConstant);
                else ntarget += target[i];
            }
            nstr = ntarget;
            return true;
        }

        /// <summary>
        /// 指定した文字列を小文字に変換し、格納します。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="nstr"></param>
        /// <returns>変換に成功したかどうか</returns>
        public static bool ToLower(string target,ref string nstr)
        {
            string ntarget = "";
            for(int i = 0;i < target.Length;i++)
            {
                if (target[i] >= 'A' && target[i] <= 'Z') ntarget += (char)(target[i] + UpLowerConstant);
                else ntarget += target[i];
            }
            nstr = ntarget;
            return true;
        }
    }
}
