using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using System.Timers;

namespace ThreeQuestions
{
    static class Program
    {
        static System.Timers.Timer clock = new System.Timers.Timer(5000);
        static Boolean timeIsUp = false;

        public static void TimeIsUp(object? sender, ElapsedEventArgs e)
        {
            clock.Stop();
            timeIsUp = true;

            Console.WriteLine("You ran out of time! The answer was 42.");
        }



        public static void Main()
        {
            clock.Elapsed += TimeIsUp;

            //prompt user on which question they want to answer
            Console.Write("Choose your question (1 - 3): ");

        start:

            //store user input in userInput
            string userInput = Console.ReadLine();

            //int value to store question choice
            int question;

            //try parsing the string into an integer
            try
            {
                //parses 
                question = int.Parse(userInput);

                if (0 > question || question > 4)
                {
                    Console.WriteLine("Enter a number between 1 and 3.");
                    goto start;
                }
            }
            catch
            {
                Console.WriteLine("Input Invalid, enter a number between 1 and 3.");
                goto start;
            }

            //Tell the user they have limited time to answer the next question
            Console.WriteLine("You have 5 seconds to answer the followign question:");

            //start the timer
            clock.Start();

            do
            {

            } while (true);

            if(question == 1)
            {
                
            }
            else if(question == 2){

            }
            else
            {

            }

            
            



        }
    }
}