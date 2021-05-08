using System;

namespace MathAndComparisons.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 Hourly Rate: ");
            double hourlyPerson1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 1 Hours Worked per Week: ");
            double hoursWorkedPerson1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2 Hourly Rate: ");
            double hourlyPerson2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2 Hours Worked per Week: ");
            double hoursWorkedPerson2 = Convert.ToDouble(Console.ReadLine());

            double annualSalaryPerson1 = hourlyPerson1 * Convert.ToDouble(52) * hoursWorkedPerson1;
            Console.WriteLine("Annual salary of Person 1: $" + annualSalaryPerson1);
            double annualSalaryPerson2 = hourlyPerson2 * Convert.ToDouble(52) * hoursWorkedPerson2;
            Console.WriteLine("Annual salary of Person 2: $" + annualSalaryPerson2);

            bool personOneMakesMore = annualSalaryPerson1 > annualSalaryPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(personOneMakesMore);

            Console.ReadLine();
        }
    }
}
