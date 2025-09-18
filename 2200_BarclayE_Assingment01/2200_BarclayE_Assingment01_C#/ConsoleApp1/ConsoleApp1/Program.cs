using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

/*
Name: Evan Barclay
Class: INFO 2200
Section: M01
Professor: Sharp
Date: 09/09/2025
Participation or Assignment #: assingment 01
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

namespace _2200_BarclayE_Assingment01
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Evan's College Town Lookup App");
            Console.WriteLine();
            Console.Write("Please enter a college or Random and I will return the city (x to exit): ");
            string userInput = Console.ReadLine().ToLower();
            Dictionary<string, string> collegecityDict = new Dictionary<string, string>();

            StreamReader reader = new StreamReader("colleges_city.txt");

            // Create TextInfo for ToTitleCase
            TextInfo myCollege = new CultureInfo("en-US", false).TextInfo;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tempcollcity = line.Split(',');
                string college = tempcollcity[0];
                string city = tempcollcity[1];
                if (!collegecityDict.ContainsKey(college.ToLower()))
                {
                    collegecityDict.Add(myCollege.ToTitleCase(college.ToLower()), myCollege.ToTitleCase(city.ToLower()));
                }
            }

            reader.Close();

            while (userInput != "x")
            {

                if (collegecityDict.TryGetValue(userInput.ToUpper(), out string city))
                {
                    Console.WriteLine();
                    Console.WriteLine($"college: {userInput}");
                    Console.WriteLine($"city: {city}");
                    Console.WriteLine();
                }

                else if (userInput == "random")
                {
                    Random rand = new Random();
                    int index = rand.Next(collegecityDict.Count);
                    var randomCollege = collegecityDict.ElementAt(index);
                    Console.WriteLine();
                    Console.WriteLine($"college: {randomCollege.Key}");
                    Console.WriteLine($"city: {randomCollege.Value}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Could not find {userInput} in the database");
                    Console.WriteLine();
                }

                Console.Write("Please enter a college and I will return the city (x to exit): ");
                userInput = Console.ReadLine().ToLower();
            }
        }
    }
}
