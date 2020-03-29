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

            runAE2();
            runTestArry();

        }

        private static void runAE2()
        {
            // Calculate 1's complement
            int nb = 50;
            Console.WriteLine("Complement number of " + nb + " is " + AE2.numberComplement(nb));

            // Execute palindrom method
            Console.WriteLine("<abcdefgfedcba>:" + AE2.palindrom("abcdefgfedcba"));
            Console.WriteLine("<AbcdefGFedcba>:" + AE2.palindrom("AbcdefGFedcba"));
            Console.WriteLine("<bcdefgfedcba>:" + AE2.palindrom("bcdefgfedcba"));
            Console.WriteLine("<     >:" + AE2.palindrom("     "));
        }

        private static void runTestArry()
        {
            // Run hourglassSum
            Console.WriteLine(ExerciseArray.hourglassSum());

            // Run rotLeft
            ExerciseArray.rotLeft(new int[15] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13);
            ExerciseArray.rotLeftPerf(new int[15] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13);

            ExerciseArray.minimumBribes(new int[5] { 2, 1, 5, 3, 4 });
            ExerciseArray.minimumBribes(new int[5] { 1, 2, 3, 4, 5 });
            ExerciseArray.minimumBribes(new int[5] { 2, 3, 4, 5, 1 });
            ExerciseArray.minimumBribes(new int[5] { 2, 5, 1, 3, 4 });
            ExerciseArray.minimumBribes(new int[10] { 3, 1, 2, 5, 4, 7, 6, 8, 10, 9 });
            ExerciseArray.minimumBribes(new int[8] { 1, 2, 5, 3, 7, 8, 6, 4 });

            ExerciseArray.minimumBribesPerf(new int[5] { 2, 1, 5, 3, 4 });
            ExerciseArray.minimumBribesPerf(new int[5] { 1, 2, 3, 4, 5 });
            ExerciseArray.minimumBribesPerf(new int[5] { 2, 3, 4, 5, 1 });
            ExerciseArray.minimumBribesPerf(new int[5] { 2, 5, 1, 3, 4 });
            ExerciseArray.minimumBribesPerf(new int[10] { 3, 1, 2, 5, 4, 7, 6, 8, 10, 9 });
            ExerciseArray.minimumBribesPerf(new int[8] { 1, 2, 5, 3, 7, 8, 6, 4 }); 

            ExerciseArray.minimumSwaps(new int[7] {7, 1, 3, 2, 4, 5, 6 });
            ExerciseArray.minimumSwapsPerf(new int[7] { 7, 1, 3, 2, 4, 5, 6 });

            ExerciseArray.minimumSwapsPerf(new int[7] { 7, 1, 3, 2, 4, 5, 6 });
            ExerciseArray.minimumSwapsPerf(new int[4] { 4, 3, 1, 2 });
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

    }
}