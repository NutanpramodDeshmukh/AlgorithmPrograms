using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class permutations
    {

        static void permute(String s, String answer)
        {
            if (s.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String rest = left_substr + right_substr;
                permute(rest, answer + ch);
            }
        }

        // Driver code
        public static void Main(String[] args)
        {

            String s = "ABC";
            String answer = "";

            Console.Write("\nAll possible strings are : ");
            permute(s, answer);
        }
    }

}
