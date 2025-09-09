using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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

           

            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tempcollcity = line.Split(',');
                string college = tempcollcity[0];
                string city = tempcollcity[1];
                if (!collegecityDict.ContainsKey(college.ToUpper()))
                {
                    collegecityDict.Add(college.ToUpper(), city.ToUpper());
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
