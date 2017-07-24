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
            if (s.Length == 0)
                return "";
            if (s.Length == 1)
                return s.ToUpper();
            if (s.Length == 2)
                return s[0].ToString().ToUpper() + "-" + s[1].ToString().ToUpper() + s[1].ToString().ToLower();

            var result="";
            var upper = "";
            for (int i = 0; i < s.Length; i++)
            {
                upper = s[i].ToString().ToUpper();
                var lower = "";
                for (int j = 0; j < i; j++)
                {
                    lower += s[i].ToString().ToLower();
                }
                result += upper + lower + "-";

            }

            return result.TrimEnd('-');
        }
    }
}
