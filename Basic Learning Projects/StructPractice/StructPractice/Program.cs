using System;

namespace StructPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of Number type
            Number number = new Number();
            number.Amount = 4.54M;


            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
