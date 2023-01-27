using System;

//Homework 3 Sawyer Nicastro
namespace HomeworkThree
{
    //Program class
    static internal class Program
    {
        //main method
        public static void Main(String[] args)
        {
            //variable to hold user input
            int iUserNum = 0;

            //variable to hold the sum of the four numbers
            int numSum = 0;

            //boolean, false if user input is invalid
            bool uiValid = false;

            //for loop prompting user for 4 numbers
            for(int i = 0; i < 4; i++)
            {
                //prompt
                Console.WriteLine("Type an number.");

                //reset while loop
                uiValid = false;

                //while loop will loop until a valid number is passed to iUserNum
                while (!uiValid)
                {
                    //try catch will prompt the user for an integer and put it into iUserNum unless the input is invalid
                    try
                    {
                        iUserNum = Convert.ToInt32(Console.ReadLine());
                        uiValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please type an integer");
                    }
                }

                //adding iUserNum to sum
                numSum += iUserNum;
            }

            //print out sum
            Console.WriteLine("Your sum is: " + numSum);
        }
    }
}