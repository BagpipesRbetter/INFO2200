using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* Name: Evan Barclay
   Class: INFO 2200               Section: 001
   Professor: Sharp               Date:
   Participation / Assignment #: 

   By submitting this assignment, I declare that the source code contained in this
   assignment was written solely by me, unless specifically provided in the assignment.
   I attest that no part of this assignment, in whole or in part, was directly created
   by Generative AI, unless explicitly colleged in the assignment instructions, nor
   obtained from a subscription service. I understand that copying any source code,
   in whole or in part, unless specifically provided in the assignment, constitutes
   cheating, and that I will receive a zero on this project if I am found in
   violation of this policy. */

namespace _2200_BarclayE_Assingment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Evan's College Town Lookup App");
            Console.WriteLine();
            Console.Write("Please enter a college or Random and I will return the city (x to exit): "); // prompt the user for input
            string userInput = Console.ReadLine().ToLower(); // assign console input to string variable and convert to lowercase
            Dictionary<string, string> collegecityDict = new Dictionary<string, string>(); // create dictionary containing two string values

            StreamReader reader = new StreamReader("colleges_city.txt"); // create a StreamReader object and assign the input file to it

            //reader.ReadLine(); // "consumes" first record containing college,cityital heading

            // loop to read in the contents of the file until end of stream
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine(); // returns line as a string
                string[] tempcollcity = line.Split(','); // splits college/cityital into key/value pair
                string college = tempcollcity[0];
                string city = tempcollcity[1];
                if (!collegecityDict.ContainsKey(college.ToUpper()))
                {
                    collegecityDict.Add(college.ToUpper(), city.ToUpper());
                } // not title case, convert college to all citys as the key
            }

            reader.Close();
            // loop to cotinue while user input is not equal to lowercase x
            while (userInput != "x")
            {
                // call the TryGetValue() method
                if (collegecityDict.TryGetValue(userInput.ToUpper(), out string city))
                {
                    Console.WriteLine(); // display blank line
                    Console.WriteLine($"college: {userInput}"); // display value of userInput variable
                    Console.WriteLine($"city: {city}"); // display print value of userInput variable
                    Console.WriteLine(); // display blank line
                }
                
                else if (userInput.ToLower == "random") // if user input is equal to "random"
                {
                    Random rand = new Random(); // create a Random object
                    int index = rand.Next(collegecityDict.Count); // generate a random index based on the number of items in the dictionary
                    var randomCollege = collegecityDict.ElementAt(index); // get the key/value pair at the random index
                    Console.WriteLine(); // display blank line
                    Console.WriteLine($"college: {randomCollege.Key}"); // display the key of the random key/value pair
                    Console.WriteLine($"city: {randomCollege.Value}"); // display the value of the random key/value pair
                    Console.WriteLine(); // display blank line
                }
                else
                {
                    Console.WriteLine($"Could not find {userInput} in the database"); // display error message
                    Console.WriteLine(); // display blank line
                }

                Console.Write("Please enter a college and I will return the city (x to exit): "); // prompt for secondary read
                userInput = Console.ReadLine().ToLower(); // secondary read
            }
        }
    }
}
