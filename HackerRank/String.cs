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
            string anagram="";

            /*if (a.Length >= b.Length) {
                longer = a;
                smaller = b;
            }
            else {
                longer = b;
                smaller = a;
            }*/

            for (int i=0; i < a.Length; i++)
            {
                if (b.IndexOf(a[i]) == -1)
                {
                    res++;
                }
                else
                {
                    if (anagram.IndexOf(a[i]) == -1) {
                        anagram+= a[i];
                    }
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (a.IndexOf(b[i]) == -1)
                {
                    res++;
                }
                else
                {
                    if (anagram.IndexOf(b[i]) == -1)
                    {
                        anagram += b[i];
                    }
                }
            }

            Console.WriteLine(anagram);

            return res;

        }
    }
}
