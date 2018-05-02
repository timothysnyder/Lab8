using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Database for 1.Names 2.Hometown & 3.Favorite Food

            //1.Names
            string[] Names = { "Donnie", "Danny", "Joey", "Jordan", "Jonathon", "AJ", "Howie", "Nick", "Kevin", "Brian", "Justin", "Chris", "Lance", "JC", "Joey.F", "Wyana", "Nathan", "Michael", "Shawn", "Marc" };
         
                //2. Hometowns
            string[] Hometowns = { "Detroit", "Cleveland", "Tokyo", "Los Angeles", "Toronto", "Vegas", "Toledo", "Miami", "Key West", "Marco Island", "Ft. Meyers", "Tampa", "St. Petersurgh", "New Orleans", "Louisville", "Yuma", "Folsom Prison", "Reno", "New York", "Portland", };

            //3. Favorite Food
            string[] Food = { "Pizza", "Taco Bell", "Steak", "Clams", "Imposter Lobsters", " King Crab", "Sushi", "Crab Cakes", "Chicken", "French Fried Taters...mmm-hmm!", "Fried Green Tomatoes", "Fried Shrimp", "Shrimp Scampi", "Coconut Shrimp", "Shrimp Cocktail", "Garlic Shrimp", "Shrimp Stew", "Shrimp Gumbo", "Boiled Shrimp", "Buffalo Shrimp", };

            Console.WriteLine("Welcome to our C# Class!");

            while (true)
            {
                Console.WriteLine("\n\nWhich Student Would You Like to Learn More About?\nChoose by Entering Their Student Nuber (1-20):");

                //A. get input from the user as int 

                int Index;
                while (!int.TryParse(Console.ReadLine(), out Index) || Index < 1 || Index > 20)
                {
                    Console.WriteLine("That Student Doesn't Exist. Please Enter a Number Between 1 and 20.");
                }

                //B. print the element at the provided index

                Console.WriteLine("\nStudent Number " + Index + " is "  + Names[Index - 1]);

                Console.WriteLine(Names[Index - 1] + " is From the Great City of: " + Hometowns[Index - 1]);

                Console.WriteLine(Names[Index - 1] + "'s, Favorite Food is: " + Food[Index - 1]);

                Console.WriteLine("\nWould You Like To Try Another Student? Y/N");
                string input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    break;
                }

             

            }

            

        }
    }
}
