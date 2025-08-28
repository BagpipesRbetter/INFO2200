using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Evan Barclay
   Class: INFO 2200               Section: 001
   Professor: Sharp               Date:
   Participation / Assignment #: 

   By submitting this assignment, I declare that the source code contained in this
   assignment was written solely by me, unless specifically provided in the assignment.
   I attest that no part of this assignment, in whole or in part, was directly created
   by Generative AI, unless explicitly stated in the assignment instructions, nor
   obtained from a subscription service. I understand that copying any source code,
   in whole or in part, unless specifically provided in the assignment, constitutes
   cheating, and that I will receive a zero on this project if I am found in
   violation of this policy. */

namespace _2200_BarclayE_Participation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Evan's State Capital Lookup App");
            Console.WriteLine();
            Console.Write("Please enter a state and I will return the capital (x to exit): "); // prompt the user for input
            string userInput = Console.ReadLine().ToLower(); // assign console input to string variable and convert to lowercase
            Dictionary<string, string> stateCapDict = new Dictionary<string, string>(); // create dictionary containing two string values

            StreamReader reader = new StreamReader("statecaps.txt"); // create a StreamReader object and assign the input file to it

            //reader.ReadLine(); // "consumes" first record containing State,Capital heading

            // loop to read in the contents of the file until end of stream
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine(); // returns line as a string
                string[] tempstatecaps = line.Split(','); // splits state/capital into key/value pair
                string state = tempstatecaps[0];
                string capital = tempstatecaps[1];
                stateCapDict.Add(state.ToUpper(), capital.ToUpper()); // not title case, convert State to all caps as the key
            }

            reader.Close();
            // loop to cotinue while user input is not equal to lowercase x
            while (userInput != "x")
            {
                // call the TryGetValue() method
                if (stateCapDict.TryGetValue(userInput.ToUpper(), out string cap))
                {
                    Console.WriteLine(); // display blank line
                    Console.WriteLine($"State: {userInput}"); // display value of userInput variable
                    Console.WriteLine($"Capital: {cap}"); // display print value of userInput variable
                    Console.WriteLine(); // display blank line
                }
                else
                {
                    Console.WriteLine($"Could not find {userInput} in the database"); // display error message
                    Console.WriteLine(); // display blank line
                }

                Console.Write("Please enter a state and I will return the capital (x to exit): "); // prompt for secondary read
                userInput = Console.ReadLine().ToLower(); // secondary read
            }
        }
    }
}
