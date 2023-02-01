using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            //variables that prompt the user for the upper and lower bounds
            double upperXBounds;
            double lowerXBounds;
            double upperYBounds;
            double lowerYBounds;

            //upperXbound user input validation
            redo1:
            try
            {
                Console.WriteLine("Enter new upper x bound, previous: 1.2");
                upperXBounds = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a double value");
                goto redo1;
            }

            //lowerXBound user input validation
            redo2:
            try
            {
                Console.WriteLine("Enter new lower x bound, previous: -1.2");
                lowerXBounds = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a double value");
                goto redo2;
            }

            //upperYBound user input validation
            redo3:
            try
            {
                Console.WriteLine("Enter new lower x bound, previous: 1.77");
                upperYBounds = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a double value");
                goto redo3;
            }

            //lowerYBound user input validation
            redo4:
            try
            {
                Console.WriteLine("Enter new lower x bound, previous: -.6");
                lowerYBounds = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a double value");
                goto redo4;
            }

            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = upperXBounds; imagCoord >= lowerXBounds; imagCoord -= Math.Abs((lowerXBounds - upperXBounds)/48))
            {
                for (realCoord = lowerYBounds; realCoord <= upperYBounds; realCoord += Math.Abs((lowerYBounds - upperYBounds)/80))
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
