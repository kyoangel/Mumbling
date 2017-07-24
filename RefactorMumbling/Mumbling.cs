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
                result += upper + GetLowerChars(s[i], i) + "-";

            }

            return result.TrimEnd('-');
        }

        private static string GetLowerChars(char currentChar, int times)
        {
            return new string(char.ToLower(currentChar), times);
        }
    }
}
