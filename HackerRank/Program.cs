using System.Collections.Generic;
using System.Linq;
using System;

namespace HackerRank
{

    // Methods developped during assessment test for AE2
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Calculate 1's complement
            int nb = 50;
            Console.WriteLine("Complement number of " + nb + " is " + Program.numberComplement(nb));

            // Execute palindrom method
            Console.WriteLine("<abcdefgfedcba>:" + Program.palindrom("abcdefgfedcba"));
            Console.WriteLine("<AbcdefGFedcba>:" + Program.palindrom("AbcdefGFedcba"));
            Console.WriteLine("<bcdefgfedcba>:" + Program.palindrom("bcdefgfedcba"));
            Console.WriteLine("<     >:" + Program.palindrom("     "));

            // Find odd numbers within a range
            Program.oddNumbers(3, 7);
            Program.oddNumbers(3, 8);
            Program.oddNumbers(4, 8);
            Program.oddNumbers(4, 9);
            Program.oddNumbers(4, 155);

            // Call find the number
            List<int> lst = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            Console.WriteLine("6 in the list?:" + Program.findNumber(lst, 6));
            Console.WriteLine("11 in the list?:" + Program.findNumber(lst, 11));
            Console.WriteLine("1 in the list?:" + Program.findNumber(lst, 1));
            Console.WriteLine("100 in the list?:" + Program.findNumber(lst, 100));
            Console.WriteLine("-1 in the list?:" + Program.findNumber(lst, -1));

            // Run hourglassSum
            Console.WriteLine(Program.hourglassSum());

            // Run rotLeft
            Program.rotLeft(new int[15] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13);
            Program.rotLeftPerf(new int[15] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13);

            Program.minimumBribes(new int[5] { 2, 1, 5, 3, 4 });
            Program.minimumBribes(new int[5] { 1, 2, 3, 4, 5 });
            Program.minimumBribes(new int[5] { 2, 3, 4, 5, 1 });
            Program.minimumBribes(new int[5] { 2, 5, 1, 3, 4 });
            Program.minimumBribes(new int[10] { 3, 1, 2, 5, 4, 7, 6, 8, 10, 9 });
            Program.minimumBribes(new int[8] { 1, 2, 5, 3, 7, 8, 6, 4 });

            Program.minimumBribesPerf(new int[5] { 2, 1, 5, 3, 4 });
            Program.minimumBribesPerf(new int[5] { 1, 2, 3, 4, 5 });
            Program.minimumBribesPerf(new int[5] { 2, 3, 4, 5, 1 });
            Program.minimumBribesPerf(new int[5] { 2, 5, 1, 3, 4 });
            Program.minimumBribesPerf(new int[10] { 3, 1, 2, 5, 4, 7, 6, 8, 10, 9 });
            Program.minimumBribesPerf(new int[8] { 1, 2, 5, 3, 7, 8, 6, 4 });*/

            //Program.minimumSwaps(new int[7] {7, 1, 3, 2, 4, 5, 6 });
            //Program.minimumSwapsPerf(new int[7] { 7, 1, 3, 2, 4, 5, 6 });

            Program.minimumSwapsPerf(new int[7] { 7, 1, 3, 2, 4, 5, 6 });
            Program.minimumSwapsPerf(new int[4] { 4, 3, 1, 2 });

        }

        /* Return 1's complement of the number given as parameter*/
        public static int numberComplement(int number) {

            string binary = Convert.ToString(number, 2);
            char[] complBin = new char[binary.Length];

            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == '0') {
                    complBin[j] = '1';
                } else {
                    complBin[j] = '0';
                }
            }

            //Console.WriteLine(res);

            return Convert.ToInt32(new string(complBin), 2);
        }

        /* Return true if parameter is a palindrom, otherwise return false */
        public static bool palindrom(string word)
        {

            if (word.Trim() == "") {
                return true;
            }

            word = word.ToLower();
            char[] reverse = new char[word.Length];

            int j = 0;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse[j] = word[i];
                j++;
            }

            string result = new string(reverse);
            //Console.WriteLine(result);

            return (result == word);
        }

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
            if ((l % 2 != 0) || (r % 2 != 0)) {
                length++;
            }

            // Create the list of odd numbers
            for (int i = l; i <= r; i++) {
                if (i % 2 != 0) {
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

            if ((l % 2 != 0) || (r % 2 != 0)) {
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


        // hourglassSum function.
        static int hourglassSum()
        {
            int[][] arr = new int[6][];
            arr[0] = new int[6] { 1, 1, 1, 1, 1, 1 };
            arr[1] = new int[6] { 1, 1, 1, 1, 1, 1 };
            arr[2] = new int[6] { 1, 1, 1, 1, 1, 1 };
            arr[3] = new int[6] { 1, 1, 1, 1, 1, 1 };
            arr[4] = new int[6] { 1, 1, 1, 1, 1, 1 };
            arr[5] = new int[6] { 1, 1, 1, 1, 1, 1 };

            int[] sums = new int[16];
            int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sums[k] =
                    arr[i][j] +
                    arr[i][j + 1] +
                    arr[i][j + 2] +
                    arr[i + 1][j + 1] +
                    arr[i + 2][j] +
                    arr[i + 2][j + 1] +
                    arr[i + 2][j + 2];
                    k++;
                }
            }

            return sums.Max();

        }

        // rotLeft based on creating all arrays.
        static int[] rotLeft(int[] a, int d)
        {

            int l = a.Length;
            int[] tabIni = a;

            int[] tabRes = new int[l];

            for (int k = 0; k < d; k++)
            {
                tabRes = new int[l];

                for (int i = 0; i < l - 1; i++) {
                    tabRes[i] = tabIni[i + 1];
                }

                tabRes[l - 1] = tabIni[0];
                tabIni = tabRes;
            }

            return tabRes;
        }

        // rotLeft based on simple copy. Much more performant than rotLeft1
        static int[] rotLeftPerf(int[] a, int d)
        {

            int l = a.Length;
            int[] tabRes = new int[l];

            // Copy from offset d to last index
            for (int i = 0; i < l - d; i++)
                tabRes[i] = a[d + i];

            // Copy from 0 to index d
            for (int i = 0; i < d; i++)
                tabRes[l - d + i] = a[i];

            return tabRes;
        }

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int bribes = 0;

            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return; 
                }

                for (int j = i; j < q.Length; j++)
                {
                    if (q[i] > q[j])
                    {
                        bribes++;
                    }
                }

            }

            Console.WriteLine(bribes);

        }


        // Complete the minimumBribes function below.
        static void minimumBribesPerf(int[] q)
        {

            /*
             * This algortihm counts for each person before them, how many people have a bigger number.
             */
            const int NB_BRIBE_MAX = 2;
            int bribes = 0; // no. bribes
            int limit = 0; // limit where to stop searching for bribe
            int l = q.Length-1;

            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - i > NB_BRIBE_MAX+1)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }

            // Check for everybody in the queue. Number 1 can be at last position.
            for (int i = l; i > 0; i--)
            {

                // No need to search beyond "limit" because person can bribe NB_BRIBE_MAX people maximum
                limit = q[i] == 1 ? 0 : q[i] - NB_BRIBE_MAX;
                // limit = 0 if person has sticker 1.

                for (int j = i - 1; j >= limit; j--)
                {
                    if (q[i] < q[j])
                    {
                        bribes++;
                    }
                }
            }

            Console.WriteLine(bribes);

        }

        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int swap = 0;
            int l = arr.Length;
            int curr = 0;
            int index;
            int nb_ok = 0;

            for (int i = 0; i < l && (nb_ok + swap < l); i++)
            {
                curr = arr[i];

                if (curr != i + 1) // number NOT at the right place
                {
                    index = Array.IndexOf(arr, i + 1);
                    arr[i] = arr[index];
                    arr[index] = curr;
                    swap++;
                }
                else
                {
                    nb_ok++;
                }
                Program.printArray(arr);
            }

            Console.WriteLine("\nswap=" + swap);

            return swap;
        }

        // Complete the minimumSwaps function below.
        static int minimumSwapsPerf(int[] arr)
        {
            int swap = 0;
            int l = arr.Length;
            int curr = 0;
            int index = 0;

            for (int i = 0; i < l - 1; i++)
            {
                curr = arr[i];

                if (curr != i + 1) // number NOT at the right place
                {
                    for (int j = i + 1; j < l; j++)
                    {
                        if (arr[j] == i + 1)
                        {
                            index = j;
                            break;
                        }
                    }
                    //index = Array.IndexOf(arr, i + 1);

                    arr[i] = i + 1;
                    arr[index] = curr;
                    swap++;
                }
            }

            return swap;
        }

        static void printArray(int[] arr)
        {

            Console.Write("\n[");

            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + ", ");

            }

            Console.Write( (arr[arr.Length-1]) + "]");

        }

    }
}