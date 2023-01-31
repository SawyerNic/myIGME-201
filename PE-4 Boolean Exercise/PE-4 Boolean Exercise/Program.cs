using System;

//Project 4: question 2
namespace PE4
{
    //program class
    class Program
    {
        //Main method
        public static void Main(String[] args)
        {
            //local variables
            int var1 = 0;
            int var2 = 0;
            Boolean tens = false;
            Boolean validInput = false;

            //prompt user for 2 nubmbers
            Console.WriteLine("Enter two numbers:");

            while (!tens)
            {

                //while loop breaks when user input is valid
                while (!validInput)
                {
                    //try catch sets validInput to true when user enters valid input
                    try
                    {
                        var1 = Convert.ToInt32(Console.ReadLine());
                        validInput = true;
                    }
                    catch
                    {
                        Console.WriteLine("Enter an integer please");
                    }
                }

                //reset validInput
                validInput = false;

                //Same while/try catch as above just repeated with the var2 variable
                while (!validInput)
                {
                    try
                    {
                        var2 = Convert.ToInt32(Console.ReadLine());
                        validInput = true;
                    }
                    catch
                    {
                        Console.WriteLine("Enter an integer please");
                    }
                }

                //reset validInput
                validInput = false;

                //checks if one but not both of the numbers is above 10
                if (var1 > 10 && var2 < 10)
                {
                    tens = true;
                }
                else if (var2 > 10 && var1 < 10)
                {
                    tens = true;
                }
                else
                {
                    Console.WriteLine("Enter two New numbers.");            
                }
            }

            //console output when successful
            Console.WriteLine("var1: " + var1 + ", var2: " + var2);
        }
    }
}