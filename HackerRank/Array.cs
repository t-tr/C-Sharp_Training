using System.Collections.Generic;
using System.Linq;
using System;

namespace HackerRank
{

    // Methods developped during assessment test for AE2
    class ExerciseArray
    {

        // hourglassSum function.
        public static int hourglassSum()
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
        public static int[] rotLeft(int[] a, int d)
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
        public static int[] rotLeftPerf(int[] a, int d)
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
        public static void minimumBribes(int[] q)
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
        public static void minimumBribesPerf(int[] q)
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
        public static int minimumSwaps(int[] arr)
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
                printArray(arr);
            }

            Console.WriteLine("\nswap=" + swap);

            return swap;
        }

        // Complete the minimumSwaps function below.
        // Performance test didn't pass in c# but passed in Java 8
        public static int minimumSwapsPerf(int[] arr)
        {
            int swap = 0;
            int l = arr.Length;
            //int curr = 0;
            int index = 0;

            for (int i = 0; i < l - 1; i++)
            {
                if (arr[i] != i + 1) // number NOT at the right place
                {
                    for (int j = i + 1; j < l; j++)
                    {
                        if (arr[j] == i + 1)
                        {
                            index = j;
                            break;
                        }
                    }
                    index = Array.IndexOf(arr, i + 1);

                    arr[index] = arr[i];
//                    arr[i] = i + 1;

                    swap++;
                }

                printArray(arr);
            }

            Console.WriteLine("\nswap=" + swap);

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


        // Complete the arrayManipulation function below.
        public static long arrayManipulation(int n, int[][] queries)
        {

            long max = 0;
            long[] ar = new long[n];

            for (long i = 0; i<n; i++)
            {
                ar[i]= 0;
            }

            //for (int i = qu)


                return max;

    }

    }
}