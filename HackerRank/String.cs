using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ExerciseString
    {

        public static int makeAnagram(string a, string b)
        {
            int res = 0;
            string longer;
            string smaller;
            string anagram="";
            int anagraml = 0;

            if (a.Length >= b.Length) {
                longer = a;
                smaller = b;
            }
            else {
                longer = b;
                smaller = a;
            }

            for (int i=0; i < smaller.Length; i++)
            {
                if (smaller.IndexOf(longer[i]) == -1) // check if char of longer string is in smaller string
                {
                    res++;
                }

                if (longer.IndexOf(smaller[i]) == -1) // check if char of smaller string is in longer string
                {
                    res++;
                }
            }

            // if string longer than the other
            for (int j = smaller.Length; j < longer.Length; j++)
            {
                if (smaller.IndexOf(longer[j]) == -1)
                {
                    res++;
                }
            }

            return res;

        }
    }
}
