using System;

namespace PE6
{
    class Program
    {
        //main method
        public static void Main(String[] args)
        {
            //rand holds Random() method
            Random rand = new Random();

            //makes random number between 0 and 100
            int randomNumber = rand.Next(0, 101);

            //for testing
            Console.WriteLine(randomNumber);

            //prompt
            Console.WriteLine("Please enter an integer between 0 and 100");

            //loop that executes 8 times, breaks out if number is guessed
            for (int i = 0; i < 8; i++)
            {

                //string will hold user input
                int guess;

                

                //push user input to guess string and validate
                redo:
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    //Make user re-enter their number if they go out of bounds
                    if(guess < 0 || guess > 100)
                    {
                        Console.WriteLine("Enter a number within bounds Please");
                        goto redo;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter an integer please");
                    goto redo;
                }

                //compare the two strings
                if(guess < randomNumber)
                {
                    Console.WriteLine("higher");
                }
                else if(guess > randomNumber)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }

                //If they dont get it correct
                if(i == 7)
                {
                    Console.WriteLine("The correct number was " + randomNumber);
                }
            }
        }
    }
}