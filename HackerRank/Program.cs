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
            // Calculate 1's complement
            int nb = 50;
            Console.WriteLine("Complement number of " + nb + " is " + Program.numberComplement(nb));

            // Execute palindrom method
            Console.WriteLine("<abcdefgfedcba>:" + Program.palindrom("abcdefgfedcba"));
            Console.WriteLine("<AbcdefGFedcba>:" + Program.palindrom("AbcdefGFedcba"));
            Console.WriteLine("<bcdefgfedcba>:" + Program.palindrom("bcdefgfedcba"));
            Console.WriteLine("<     >:" + Program.palindrom("     "));

            // Find odd numbers within a range
            Program.oddNumbers(3,7);
            Program.oddNumbers(3, 8);
            Program.oddNumbers(4, 8);
            Program.oddNumbers(4, 9);
            Program.oddNumbers(4, 155);

            // Call find the number
            List<int> lst = new List<int>(10) { 1,2,3,4,5,6,7,8,9,100};
            Console.WriteLine("6 in the list?:" + Program.findNumber(lst,6));
            Console.WriteLine("11 in the list?:" + Program.findNumber(lst, 11));
            Console.WriteLine("1 in the list?:" + Program.findNumber(lst, 1));
            Console.WriteLine("100 in the list?:" + Program.findNumber(lst, 100));
            Console.WriteLine("-1 in the list?:" + Program.findNumber(lst, -1));

            // Run hourglassSum
            Console.WriteLine(Program.hourglassSum());

        }

        /* Return 1's complement of the number given as parameter*/
        public static int numberComplement(int number){

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

            if (word.Trim() == ""){
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

            int length = (r - l)/2;

            // Add 1 to the total number if l or r if an odd number
            if ((l % 2 != 0) || (r % 2 != 0)){
                length++;
            }

            // Create the list of odd numbers
            for (int i=l; i <= r; i++) {
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

    }
}
