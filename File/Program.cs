
using System;

namespace File
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content        

            File.Delete("filename.txt");

            try{
                readText = File.ReadAllText("filename.txt");  // Read the contents of the file
                Console.WriteLine(readText);  // Output the content        
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when reading the file: " + e.Message);
            }
        }
    }
}
