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
            string output = "";

            
            for(int i = userInput.Length; i > 0; i--)
            {
                output += userInput.Substring(i - 1, 1);
            }

            Console.WriteLine(output);
        }
    }
}