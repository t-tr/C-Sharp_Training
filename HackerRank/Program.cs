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

            runBasic();
            //runAE2();
            //runTestArry();

        }

        private static void runBasic()
        {
            /*
            // Find odd numbers within a range
            BasicChallenges.oddNumbers(3, 7);
            BasicChallenges.oddNumbers(3, 8);
            BasicChallenges.oddNumbers(4, 8);
            BasicChallenges.oddNumbers(4, 9);
            BasicChallenges.oddNumbers(4, 155);

            // Call find the number
            List<int> lst = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            Console.WriteLine("6 in the list?:" + BasicChallenges.findNumber(lst, 6));
            Console.WriteLine("11 in the list?:" + BasicChallenges.findNumber(lst, 11));
            Console.WriteLine("1 in the list?:" + BasicChallenges.findNumber(lst, 1));
            Console.WriteLine("100 in the list?:" + BasicChallenges.findNumber(lst, 100));
            Console.WriteLine("-1 in the list?:" + BasicChallenges.findNumber(lst, -1));
            */

            /*Console.WriteLine("SockMerchant:" + BasicChallenges.sockMerchant(9, new int[] {10, 20, 20, 10, 10, 30, 50, 10, 20 }));
            Console.WriteLine("countingValleys:" + BasicChallenges.countingValleys(12, "DDUUDDUDUUUD"));*/
            Console.WriteLine("jumpingOnClouds=" + BasicChallenges.jumpingOnClouds(new int[] {0,0,0,1,0,0 }));


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
    }
}