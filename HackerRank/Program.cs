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

            runEasyChallenges();
            //runAE2();
            //runTestArray();
            //runTestString();
        }

        private static void runTestString()
        {
            /*Console.WriteLine("alternatingCharacters:" + ExerciseString.alternatingCharacters("AAAAAA"));
            Console.WriteLine("alternatingCharacters:" + ExerciseString.alternatingCharacters("BBB"));
            Console.WriteLine("alternatingCharacters:" + ExerciseString.alternatingCharacters("ABABABAB"));
            Console.WriteLine("alternatingCharacters:" + ExerciseString.alternatingCharacters("BABABA"));
            Console.WriteLine("alternatingCharacters:" + ExerciseString.alternatingCharacters("AAABBB"));*/

            //TODO finish makeAnagram
            Console.WriteLine("makeAnagram:" + ExerciseString.makeAnagram("cde","abc"));
            Console.WriteLine("makeAnagram:" + ExerciseString.makeAnagram("showman", "woman"));
            Console.WriteLine("makeAnagram:" + ExerciseString.makeAnagram("abeec", "ebz"));
            Console.WriteLine("makeAnagram:" + ExerciseString.makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke"));
            Console.WriteLine("makeAnagram:" + ExerciseString.makeAnagram("jxwtrhvujlmrpdoqbisbwhmgpmeoke", "fcrxzwscanmligyxyvym"));
        }

        private static void runEasyChallenges()
        {
            /*
            // Find odd numbers within a range
            Easy.oddNumbers(3, 7);
            Easy.oddNumbers(3, 8);
            Easy.oddNumbers(4, 8);
            Easy.oddNumbers(4, 9);
            Easy.oddNumbers(4, 155);

            // Call find the number
            List<int> lst = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            Console.WriteLine("6 in the list?:" + Easy.findNumber(lst, 6));
            Console.WriteLine("11 in the list?:" + Easy.findNumber(lst, 11));
            Console.WriteLine("1 in the list?:" + Easy.findNumber(lst, 1));
            Console.WriteLine("100 in the list?:" + Easy.findNumber(lst, 100));
            Console.WriteLine("-1 in the list?:" + Easy.findNumber(lst, -1));
            */

            /*Console.WriteLine("SockMerchant:" + Easy.sockMerchant(9, new int[] {10, 20, 20, 10, 10, 30, 50, 10, 20 }));
            Console.WriteLine("countingValleys:" + Easy.countingValleys(12, "DDUUDDUDUUUD"));
            Console.WriteLine("jumpingOnClouds:" + Easy.jumpingOnClouds(new int[] {0,0,0,1,0,0 }));*/
            /*Console.WriteLine("repeatedString:" + Easy.repeatedString("aba", 10));
            Console.WriteLine("repeatedString:" + Easy.repeatedString("a", 10000000));*/

            /*List<int> lst1 = new List<int> { 11, 2, 4 };
            List<int> lst2 = new List<int> { 4, 5, 6 };
            List<int> lst3 = new List<int> { 10, 8, -12 } ;
            List<List<int>> lst = new List<List<int>>();
            lst.Add(lst1);
            lst.Add(lst2);
            lst.Add(lst3);
            Console.WriteLine("diagonalDifference:" + Easy.diagonalDifference(lst)); // Excpeted result is 15*/

            /*Easy.plusMinus(new int[] { -4, 3, - 9, 0, 4, 1 });
            //Expected Output: 0.375000, 0.375000, 0.250000
            Easy.plusMinus(new int[] { 1, 2, 3, - 1, - 2, - 3, 0, 0 });*/

            /*
             *     #
             *    ##
             *   ###
             *  ####
             * #####*/
            //Easy.staircase(5);

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

        private static void runTestArray()
        {
            // Run hourglassSum
            /*Console.WriteLine(ExerciseArray.hourglassSum());

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
            ExerciseArray.minimumSwapsPerf(new int[4] { 4, 3, 1, 2 });*/


            // TODO finish arrayManipulation
            int[][] queries = new int[3][] {
                new int[] {1, 2, 100 },
                new int[] {2, 5, 100 },
                new int[] {3, 4, 100 }
            };

            Console.WriteLine("" + ExerciseArray.arrayManipulation(5, queries));

        }
    }
}