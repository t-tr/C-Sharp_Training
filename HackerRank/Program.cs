﻿using System;

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
        }

        /* return 1's complement of the number given as parameter*/
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

        /* Return true if parameter is a palindrom, otherwise returns false */
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
    }
}
