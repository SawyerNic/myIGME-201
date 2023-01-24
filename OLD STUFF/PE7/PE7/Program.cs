using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    class readTextFile
    {
        static void Main(String[] args)
        {
            //prompt for user to type their name
            //Console.WriteLine("Type your name:");
            //string name = Console.ReadLine();

            //read madlib template file
            string template = System.IO.File.ReadAllText("/Users/sawyernicastro/Desktop/IGME 201/PE7/PE7/MadLibsTemplate.txt");
            //I dont know why the system read the text file into an array

            template = template.Substring(0, template.IndexOf("Here is a"));

            //Console.WriteLine(template);

            //Console.WriteLine(template);
            string[] lines = template.Split(" ");

            //string that holds the output
            string output = "";

            //loops through each word in the story
            foreach(string i in lines)
            {
                //string to hold the prompt word
                string adLib = "";

                //adds line break
                if(i == "\n")
                {
                    output += "\n";
                }

                //determines if the word is within brackets
                if (System.Text.RegularExpressions.Regex.IsMatch(i.Substring(0, 1), "{"))
                {

                    //takes the word out of the brackets and puts it into a string, modifies it so it works in a sentence
                    adLib = i.Substring(1, i.IndexOf("}") - 1);
                    adLib = adLib.ToLower();
                    adLib = adLib.Replace("_", " ");

                    //writes the prompt
                    //determines if 'a' or 'an' is gramatically appropriate
                    if(adLib.Substring(0,1) == "a")
                    {
                        Console.WriteLine("Enter an " + adLib);
                    }
                    else
                    Console.WriteLine("Enter a " + adLib);

                    //if the word is within brackets, this 
                    output += Console.ReadLine() + " ";
                }
                else
                {
                    //adds non prompt words in between the user input
                    output += i + " ";
                }

                

                //check if string has brackets
            }
            Console.WriteLine(output);
        }
    }
}