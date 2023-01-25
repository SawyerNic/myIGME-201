using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 - Syntax error: forgot semicolon
            int i = 0;

            string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) - logical error: var i needs to start at 0 instead of 1, this would only loop 9 times
            //for (i = 0; i < 10; i++) - run time error: var i cannot be 0 because the program then divides by 0, thus we will use 1 and increase the parameter to 11
            for (i = 1; i < 11; i++)
            {
                // declare string to hold all numbers
                //string allNumbers = null; - Logic error: allNumbers should be defined outsiede the for loop, see line 22

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); - syntax error, needs parentheses around i - 1
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1)); Run time error: cant divide by 0
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Cant divide by zero");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; - logic error: this incrementation is not necessary because i is incremented in the beginning of the for loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); - syntax error: needs + between quotes and variables
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}