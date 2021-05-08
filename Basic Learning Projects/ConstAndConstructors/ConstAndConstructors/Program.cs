using System;

namespace ConstAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string employer = "Acme, Inc.";

            Employee employee1 = new Employee();

            Console.WriteLine(employee1.Id);
            Console.WriteLine(employee1.Title);
            Console.WriteLine(employer);

        }
    }
}
