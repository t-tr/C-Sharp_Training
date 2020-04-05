using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ExerciseString
    {

        public static int alternatingCharacters(string s)
        {

            int del = 0;
            int l = s.Length;

            for (int i = 0; i < l - 1; i++)
            {

                if (s[i] == s[i + 1])
                {
                    del++;
                }
            }

            return del;

        }

        public static int makeAnagram(string a, string b)
        {
            int res = 0;
            int db = 0;
            string lg;
            string sm;
            string anagram="";

            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;

            if (a.Length >= b.Length) {
                lg = a;
                sm = b;
            }
            else {
                lg = b;
                sm = a;
            }

            for (int i=0; i < lg.Length; i++)
            {
                if (sm.IndexOf(lg[i]) != -1)  // found
                {
                    if (anagram.IndexOf(lg[i]) == -1)
                    {
                        anagram += lg[i];
                    }
                }
            }


            res = sm.Length + lg.Length;

            Console.WriteLine(anagram);

            return res;

        }
    }
}
