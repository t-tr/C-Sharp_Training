using System;
using System.Linq;

namespace HelloWorld
{
    class Basics
    {
        static void Main(string[] args)
        {
            // Write "Hello" message
            string name = "Jacques Tati";
            Console.WriteLine("Hello " + name);

            // Declare variables
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            /* This is a comment*/

            // Cast and conversions
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // Read input from console
            Console.WriteLine("John, how old are you?");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fred, how old are you?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            // Math
            Console.WriteLine("Older is " + Math.Max(age1, age2));
            Console.WriteLine("Sqaure root of 100 is: " + Math.Sqrt(100));
            Console.WriteLine("Round method: " + Math.Round(2.99));

            // string interpolation 
            string firstName = "John";
            string lastName = "Doe";
            name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name + "/" + name.ToUpper());

            // Evaluate expression
            Console.WriteLine(10 > 9);

            // Ternary Operator
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            // Arrays
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            cars[0] = "Peugeot";

            // Loops
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort array
            int[] tab = {1,5,2,22,3,-1,9,9 };
            Array.Sort(tab);

            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }

            // Max array
            Console.WriteLine(tab.Max());

            // Enumerators
            Console.WriteLine("Value for " + Level.High + " is " + (int)Level.High);

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

        }

        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

    }
}
