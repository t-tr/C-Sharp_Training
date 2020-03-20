using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 0;
            string name = "toto";
            Console.WriteLine("Hello " + name);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            /*Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));*/   // convert bool to string

            /*Console.WriteLine("John, how old are you?");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fred, how old are you?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Older is " + Math.Max(age1,age2));*/

            Console.WriteLine(10 > 9);

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            cars[0] = "Peugeot";

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] tab = {1,5,2,22,3,-1,9,9 };
            Array.Sort(tab);

            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(tab.Max());
        }

    }
}
