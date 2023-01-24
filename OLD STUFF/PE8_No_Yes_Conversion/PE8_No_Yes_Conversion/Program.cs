using System;
using System.IO;

namespace reverseString
{
    class test
    {
        static void Main()
        {
            //Take string from user
            string userInput = Console.ReadLine();
            string lowerCase = userInput.ToLower();
            string output = "";


            string[] split = lowerCase.Split("yes");


            foreach (string i in split)
            {
                output += i + "no";
            }

            Console.WriteLine(output);
        }
    }
}