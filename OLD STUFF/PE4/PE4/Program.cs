using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    //Class: program
    //Author: Sawyer Nicastro
    class program
    {

        static void Main(String[] args)
        {
            //var1 and var2 will obtain values given by user
            int var1 = 0;
            int var2 = 0;

            //prompt changes if user doesnt get it on first try
            string prompt = "Enter two numbers";

            //while loop wont terminate unless there is one number over ten and one number under
            while((var1 > 10 && var2 > 10) || (var1 < 10 && var2 < 10))
            {
                //ask user to enter two numbers
                Console.Write(prompt + "\n");

                //parse input to int
                var1 = int.Parse(Console.ReadLine());
                var2 = int.Parse(Console.ReadLine());

                //change prompt in case user guesses incorrect
                prompt = "Enter two different numbers";
            }

            //display the numbers when they are correct
            Console.Write(var1 + " and " + var2);


        }
    }
}