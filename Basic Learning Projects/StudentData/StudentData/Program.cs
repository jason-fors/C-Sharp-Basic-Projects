using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;


namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var student = new Student { 
                    FirstName = "Jason",
                    LastName = "Fors",
                    EmailAddress = "jasonfors@thatschool.edu",
                    GPA = 4.00,
                    FullTime = true
                    
                };
                db.Students.Add(student);
                db.SaveChanges();

                var allStudents = from st in db.Students
                            orderby st.Id
                            select st;

                Console.WriteLine("All students in the database:");
                foreach (var item in allStudents)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double GPA { get; set; }
        public bool FullTime { get; set; }

    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}
