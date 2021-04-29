using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod2
{
    public class DivideByTwo
    {
        public static int divisor = 2;

        // A method handing result back using an output parameter.
        public void Divide2(int num1, out int result)
        {
            result = num1 / divisor;
        }

        // Overloading method...this one just presents result on console.
        public void Divide2(int num1)
        {
            Console.WriteLine(num1 / divisor);
        }

        // Static method to change divisor for the class.
        public static void setDivisor(int newDivisor)
        {
            divisor = newDivisor;
        }
    }
}
