using System;
using System.IO;

namespace IO_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string text = Console.ReadLine();
            // This overwrites the contents of the file.
            File.WriteAllText(@"C:\Users\Jason Fors\Desktop\IO_Practice\Logs\log.txt", text);

            string textRead = File.ReadAllText(@"C:\Users\Jason Fors\Desktop\IO_Practice\Logs\log.txt");
            Console.WriteLine(textRead);

        }
    }
}
