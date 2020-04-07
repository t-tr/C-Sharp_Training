using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Easy
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

        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {

            List<int> listColors = new List<int>();
            int nbPairs = 0;
            int nbSocks = 0;

            // Count the number of colors
            for (int i = 0; i < n; i++)
            {
                if (!listColors.Contains(ar[i]))
                {
                    listColors.Add(ar[i]);
                }
            }

            foreach (int var in listColors)
            {
                nbSocks = 0;
                for (int i = 0; i < n; i++)
                {
                    if (ar[i]==var)
                    {
                        nbSocks++;
                    }
                }
                nbPairs += nbSocks / 2;
            }

            return nbPairs;
        }

        /*
         * Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like topography.
         * During his last hike he took exactly steps. For every step he took, he noted if it was an uphill, , or a downhill, step.
         * Gary's hikes start and end at sea level and each step up or down represents a unit change in altitude. We define the following terms:
         * A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
         * A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
         * Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
         * 
         * For example, if Gary's path is, he first enters a valley units deep. Then he climbs out an up onto a mountain units high.
         * Finally, he returns to sea level and ends his hike. */
        public static int countingValleys(int n, string s)
        {

            int level = 0;
            int valleys = 0;
            bool isValley = false;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D')
                {
                    level--;
                    if (level == -1)
                    {
                        isValley = true;
                    }
                }
                if (s[i] == 'U')
                {
                    level++;
                    if (level == 0 && isValley)
                    {
                        isValley = false;
                        valleys++;
                    }
                }
            }

            return valleys;

        }

        public static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int current = 0;
            int l = c.Length;

            for (int i = 0; i < l - 1; i++)
            {

                if (i + 2 < l)
                {
                    if (c[i + 2] == 0)
                    {
                        i++; // jump over 1 cloud
                    }
                    jumps++; // jump onto the next cloud
                }
                else
                {
                    if (i == l - 2 && c[i + 1] == 0)  // last cloud
                    {
                        jumps++;
                    }
                }
            }

            return jumps;
        }

        public static long repeatedString(string s, long n)
        {

            long rest = 0;
            long xfactor = 0;
            int total = 0;
            int nb_rest = 0;
            int l = s.Length;

            xfactor = n / l;
            rest = n % l;

            for (int i = 0; i < l; i++)
            {

                if (s[i] == 'a')
                {
                    total++;
                }

                if (i == rest - 1)
                {
                    nb_rest = total;
                }

            }

            return xfactor * total + nb_rest;

        }

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diag1 = 0;
            int diag2 = 0;

            int l = arr[0].Count;

            for (int i = 0; i < l; i++)
            {
                diag1 += arr[i][i];
                diag2 += arr[i][l - i - 1];
            }

            return Math.Abs(diag1 - diag2);

        }

        /*
         * Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.
         * Print the decimal value of each fraction on a new line.
         */
        public static void plusMinus(int[] arr)
        {

            Double plus = 0;
            Double minus = 0;
            Double l = arr.Length;

            for (int i = 0; i < l; i++)
            {
                if (arr[i] > 0)
                {
                    plus++;
                }
                if (arr[i] < 0)
                {
                    minus++;
                }
            }

            Console.WriteLine("{0:N6}", plus / l);
            Console.WriteLine("{0:N6}", minus / l);
            Console.WriteLine("{0:N6}", ((l - minus - plus) / l));

        }

        public static void staircase(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }


        }

        public static void miniMaxSum(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            long sum = arr[0];

            for (int i = 1; i < 5; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }

            Console.Write(sum - max + " ");
            Console.Write(sum - min);
        }

        // Complete the birthdayCakeCandles function below.
        public static int birthdayCakeCandles(int[] ar)
        {
            int candles = 0;
            int tallest = ar[0];

            for (int i = 0; i < ar.Length; i++)
            {
                if (tallest < ar[i])
                {
                    tallest = ar[i];
                    candles = 0;
                }

                if (tallest == ar[i])
                {
                    candles++;
                }
            }

            return candles;
        }
    }
}
