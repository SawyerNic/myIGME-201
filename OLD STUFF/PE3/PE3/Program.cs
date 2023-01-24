using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{

    class program
    {
        static void Main(string[] args)
        {
            Console.Write("type four numbers\n");

            int total = 0;

            for(int i = 0; i < 4; i++)
            {
                string line = Console.ReadLine();

                try
                {
                    total += (int)Convert.ToDouble(line);
                }
                catch
                {
                    Console.Write("Please enter an intiger");
                    i--;
                }
            }

            Console.Write("Sum: " + total);

            


        }
    }
}