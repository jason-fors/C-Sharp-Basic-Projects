using System;
using System.Collections.Generic;

namespace SixPartAssignment.cs
{
    class Program
    {
        static void Main()
        {
            // Creates array of pet names
            string[] petArray = { "Wilson", "Shadow", "Toby", "KC", "Atlas" };

            // Asks user for last name
            Console.WriteLine("Enter your last name.");
            string lastName = Console.ReadLine();

            // Appends last name to each pet name
            for (int i = 0; i < petArray.Length; i++)
            {
                petArray[i] = petArray[i] + " " + lastName;
            }

            // Displays pet names with user's last name appended
            Console.WriteLine("If these pets were yours, their full names would be: ");
            for (int j = 0; j <= petArray.Length - 1; j++)
            {
                Console.WriteLine(petArray[j]);
            }

            // Creates list of unique colors
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Orange");
            colors.Add("Purple");

            // Asks user for a color
            Console.WriteLine("Guess a color!");
            string userColor = Console.ReadLine();

            // Checks if user put color that isn't in the list and, if so, tells them.
            if (!colors.Contains(userColor))
            {
                Console.WriteLine("Your color is not in the list.");
            }

            // If user chose a color on the list, tells them the index of that color.
            else
            {
                for (int m = 0; m < colors.Count; m++)
                {
                    if (colors[m] == userColor)
                    {
                        Console.WriteLine("Your color is at index " + m);
                        break;                          // Stops executing loop if color is found.
                    }
                }
            }

            // Creates list of animals with two identical strings
            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Fox");
            animals.Add("Goat");
            animals.Add("Cow");
            animals.Add("Dog");

            // Asks user for a animal
            Console.WriteLine("Guess an animal!");
            string userAnimal = Console.ReadLine();

            // Checks if user put animal that isn't in the list and, if so, tells them.
            if (!animals.Contains(userAnimal))
            {
                Console.WriteLine("Your animal is not in the list.");
            }

            // If user entered an animal on the list, tells them the index of that animal.
            else
            {
                for (int n = 0; n < animals.Count; n++)
                {
                    if (animals[n] == userAnimal)
                    {
                        Console.WriteLine("Your animal is at index " + n);
                    }
                }
            }


            // Creates list of trees with two identical strings
            List<string> trees = new List<string>();
            trees.Add("Pine");
            trees.Add("Maple");
            trees.Add("Oak");
            trees.Add("Pine");
            trees.Add("Tulip Poplar");
            trees.Add("Hickory");

            List<string> checkTrees = new List<string>();

            // Iterates through list and evaluates whether or not it has already appeared in the list.
            foreach (string tree in trees)
            {
                if (checkTrees.Contains(tree))
                {
                    Console.WriteLine(tree + " has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine(tree + " has not appeared in the list yet.");
                    checkTrees.Add(tree);
                }
            }

            Console.ReadLine();
        }
    }
}
