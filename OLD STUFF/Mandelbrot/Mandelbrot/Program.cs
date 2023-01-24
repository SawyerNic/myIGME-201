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
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //user input has to enter values between 1.2 and -1.2
            double highLim = 2, lowLim = -2;
            double newInc;
            string prompt = "Enter new upper limit between 1.2 and -1.2";

            //loop doesnt exit unless the highLim is within bounds
            while (!(highLim > -1.2 && highLim < 1.2))
            {
                Console.WriteLine(prompt);
                highLim = double.Parse(Console.ReadLine());
                prompt = "Enter WITHIN limit";
            }

            prompt = "Enter new lower limit between 1.2 and -1.2 that is lower than your previous entry";
            //loop doesnt exit unless the lowLim is within bounds
            while (!(lowLim > -1.2 && lowLim < 1.2 && lowLim < highLim))
            {
                Console.WriteLine(prompt);
                lowLim = double.Parse(Console.ReadLine());
                prompt = "Enter valid input";
            }

            //calculate how much the incriment should be modified by
            double frac = (highLim - lowLim) / 2.4;

            double topLim = 2;
            double botLim = -1;
            prompt = "Enter new top limit between -.6 and 1.77";

            //loop doesnt exit unless the highLim is within bounds
            while (!(topLim > -.6 && topLim < 1.77))
            {
                Console.WriteLine(prompt);
                topLim = double.Parse(Console.ReadLine());
                prompt = "Enter WITHIN limit";
            }

            prompt = "Enter new top limit between -.6 and 1.77";

            //loop doesnt exit unless the lowLim is within bounds
            while (!(botLim > -.6 && botLim < 1.77 && botLim < topLim))
            {
                Console.WriteLine(prompt);
                botLim = double.Parse(Console.ReadLine());
                prompt = "Enter valid input";
            }

            double frac1 = (topLim - botLim) / 2.4;

            for (imagCoord = highLim; imagCoord >= lowLim; imagCoord -= 0.05*frac)
            {
                for (realCoord = botLim; realCoord <= topLim; realCoord += 0.03*frac1)
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
