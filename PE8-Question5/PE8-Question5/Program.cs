using System;

namespace PE8
{

    class Program
    {
        public static void Main(string[] args)
        {
            /*5.	Given the formula z = 3y2 + 2x - 1 
        * write a console application to calculate 
        * z for the following ranges of x and y:
        */

            //variables
            int xI;
            int yI;
            int zI = 0;
            double x = -1;
            double y = 1;
            double z = 0;
            double[,,] arr = new double[20,30,600];

            //outer loop
            for (xI = 0; x <= 1; xI += 1)
            {
                
                //inner loop
                for(yI = 0; y <= 4; yI += 1)
                {
                    z = (3*y*y) + (2*x) - 1;
                    arr[xI, yI, zI] = z;
                    y += .1;
                    zI += 1;
                    Console.WriteLine(arr[xI, yI, zI]);
                    Console.WriteLine(x + " " + y + " " + z);
                }
                x += .1;

            }
        }
    }
}