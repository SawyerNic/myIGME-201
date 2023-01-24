using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    //class program
    //Author: Sawyer Nicastro
    class program
    {
        static void Main(String[] args)
        {
            //generates random number between 0 and 100
            Random rand = new Random();
            int num = rand.Next(0, 101);
            Console.WriteLine(num);
            //variable to store user guessed value
            int guess;

            Console.WriteLine("Enter a number between 0 and 100");

            for (int i = 1; i <= 8; i++)
            {
                guess = int.Parse(Console.ReadLine());

                if (i == 8)
                {
                    Console.WriteLine("The correct number was " + num);
                }
                else if (guess < num)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if(guess > num)
                {
                    Console.WriteLine("Guess Lower");
                }
                else if(guess == num)
                {
                    Console.WriteLine("Correct! It took you " + i + " guesses");
                    break;
                }
                
            }
        }
    }
}