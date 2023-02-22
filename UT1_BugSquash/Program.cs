using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            //string sNumber; - compile time error - need to assign variable
            string sNumber = "";
            int nX;
            //int nY - compile time error, missing semicolon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); - missing quotation marks around the string
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); logic error - need to pass variable to sNumber
                sNumber = Console.ReadLine();
                //} while (!int.TryParse(sNumber, out nX)); compile time error - use of unassigned variable sNumber
                //} while (!int.TryParse(sNumber, out nX)); run time error - infinite loop, get rid of !
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                //} while (int.TryParse(sNumber, out nX)); - logical error, need to change nX to nY
                //} while (int.TryParse(sNumber, out nY)); - run time error - infinite loop, add a !
            } while (!int.TryParse(sNumber, out nY));
                // compute the exponent of the number using a recursive function
                //nAnswer = Power(nX, nY); - compile time error needed to add "static" to line 41
                nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); logical error, need a to add the dollar sign in front of the quotations 
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
            Console.ReadLine();
        }


        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0; - logical error, return the base case instead of 0 also this won't return anything withot the keyword
                return nBase;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); - logic error, need - instead of +
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; - compile time error, need to add return
            return returnVal;
        }
    }
}