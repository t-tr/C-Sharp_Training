using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class BasicChallenges
    {

        /* Find the number k in the array.
         Return YES if found, otherwise return "NO" */
        public static string findNumber(List<int> arr, int k)
        {
            string res = "NO";

            foreach (int i in arr)
            {
                if (i == k)
                {
                    res = "YES";
                    break;
                }
            }

            return res;
        }

        /* Return the list of all odd number between l and r */
        public static List<int> oddNumbers(int l, int r)
        {
            List<int> oddLst = new List<int>();

            int length = (r - l) / 2;

            // Add 1 to the total number if l or r if an odd number
            if ((l % 2 != 0) || (r % 2 != 0))
            {
                length++;
            }

            // Create the list of odd numbers
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    oddLst.Add(i);
                }
            }

            return oddLst;
        }

        /* Return the list of all odd number between l and r */
        public static List<int> oddNumbers2(int l, int r)
        {
            List<int> oddLst = new List<int>();

            // Calculate the total number of odd numbers within the range
            int length = (r - l) / 2;

            if ((l % 2 != 0) || (r % 2 != 0))
            {
                length++;             // Add 1 to the total number if l or r if an odd number
            }

            int i = l;
            if (l % 2 != 0)
            {
                oddLst.Add(l);
                i += 2;
            }
            else
            {
                i++;
            }

            // Create the list of odd numbers
            while (i <= r)
            {
                oddLst.Add(i);
                i += 2;
            }

            return oddLst;
        }
    }
}
