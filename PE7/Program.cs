//using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace PE7
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] stories = new string[6];
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("c:\\Users\\Owner\\Documents\\Visual Studio 2022\\Templates\\MadLibsTemplate.txt");
                string line = null;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    stories[i] = line;
                    i++;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error with file: " + ex.Message);
            }

            finally
            {
                if(sr != null) sr.Close();
            }

            //ask the user if they want to play MadLibs
            Console.WriteLine("Do you want to play MadLibs?");
            //validate the user input
            string agreement = "";
            bool valid = false;
            while(!valid)
            {
                agreement = Console.ReadLine();

                if (agreement.ToLower() == "yes")
                {
                    valid = true;
                    Console.WriteLine("yay!");
                }
                else if (agreement.ToLower() == "no")
                {
                    valid = true;
                    Console.WriteLine("Goodbye");
                }
                else { Console.WriteLine("Please enter 'yes' or 'no'."); }
            }

            int storyNum = 0;
            
            if (agreement.ToLower() == "yes") {
                //prompt the user for a story number
                
                Console.WriteLine("Choose a story between 1 and 5");
                reStart:

                //validation
                try
                {
                    
                    storyNum = int.Parse(Console.ReadLine());
                    if (storyNum < 0 || storyNum > 5) {
                        Console.WriteLine("Please choose within bounds");
                        goto reStart;
                    }

                }
                catch (Exception ex) { 
                    Console.WriteLine("Enter an integer please"); 
                    goto reStart; 
                }

            }

            //the result will be build with resultString
            string resultString = "";

            //this string variable will hold user input
            string userInput;

            //store the story in a string array
            string[] story = stories[storyNum].Split(" ");

            //if else insile foreach loop that will prompt user when appropriate
            foreach(string i in story)
            {
                //if i starts with a bracket, prompt user for input
                if(i.StartsWith("{")) {

                    //wanted word
                    string wordType = i.Substring(1, i.IndexOf("}")-1).Replace("_"," ");

                    //ask the user for the word type in the brackets
                    Console.WriteLine("Enter a " + wordType);

                    //read user input
                    userInput = Console.ReadLine();

                    //add user input to resultString
                    resultString+= userInput + " ";
                }
                else if(i  == @"\n")
                {
                    resultString += "\n";
                }
                else
                {
                    resultString += i + " ";
                }
                //hello github
                
            }
            Console.WriteLine(resultString);
        }
    }
}
