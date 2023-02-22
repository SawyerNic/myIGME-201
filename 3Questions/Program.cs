using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Timers;

namespace _3Questions
{
    internal class Program
    {
        // elapsed global variable
        static bool timerElapsed = false;
        static string answer = "";


        static void Main(string[] args)
        {
            //  New timer
            Timer timer = new Timer(5000);

            //subscribe to the elapsed event of the timer
            timer.Elapsed += TimerElapsed;


        beginning:

            //Ask them to choose a question
            Console.WriteLine("Choose your question (1-3)");

            //validate the user input
            int question = 0;
            bool valid = false;
            do
            {
                try
                {
                    question = int.Parse(Console.ReadLine());

                    if (question < 4 && question> 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 3");
                    }
                }
                catch 
                {
                    Console.WriteLine("Enter an integer.");
                }
            }
            while (!valid);

            //Give the user a question based off of their input and start the timer
            bool correct = false;
            
            Console.WriteLine("You have 5 seconds to answer the following question");
            timer.Start();
            while(!correct && !timerElapsed)
            {
                switch (question)
                {
                    case 1:
                        Console.WriteLine("What is your favorite color");
                        answer = "black";
                        break;
                    case 2:
                        Console.WriteLine("What is the answer to life, the universe and everything");
                        answer = "42";
                        break;
                    case 3:
                        Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                        answer = "What do you mean? African or European swallow?";
                        break;
                }

                if(answer.CompareTo(Console.ReadLine()) == 0)
                {
                    
                    Console.WriteLine("Well done!");
                    timer.Stop();
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine("The answer is: " + answer);
                    timer.Stop();
                    break;
                }

            }

            

            //ask to play again
            Console.WriteLine("Play again?");
            Console.WriteLine("");

            if (Console.ReadLine()[0].ToString().ToLower() == "y")
            {
                goto beginning;
            }
            
            Console.ReadLine();
        }

        //calls when timer is up
        static void TimerElapsed(object sender , EventArgs e)
        {
            ((Timer)sender).Stop();
            timerElapsed = true;

            Console.WriteLine("Time's up!");

            Console.Write("The answer is: " + answer);
        }
    }
}
