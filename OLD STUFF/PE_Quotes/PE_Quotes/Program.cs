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

            string[] arr = userInput.Split(" ");

            foreach(string i in arr)
            {
                output += "\"" + i + "\" ";
            }
            output += "\"";

            Console.WriteLine(output);

        }
    }
}