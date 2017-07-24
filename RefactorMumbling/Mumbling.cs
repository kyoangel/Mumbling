using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMumbling
{
    public class Mumbling
    {
        static void Main(string[] args)
        {

        }
        public string Accum(string s)
        {
            // your code
            var result="";
            var upper = "";
            for (int i = 0; i < s.Length; i++)
            {
                upper = s[i].ToString().ToUpper();
                var lower = "";
                lower = GetLowerChars(s, i, lower);
                result += upper + lower + "-";

            }

            return result.TrimEnd('-');
        }

        private static string GetLowerChars(string currentChar, int times, string lower)
        {
            for (int j = 0; j < times; j++)
            {
                lower += currentChar[times].ToString().ToLower();
            }

            return lower;
        }
    }
}
