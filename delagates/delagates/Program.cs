using System;

namespace Delagates
{
    class Program
    {
        //definition of delegate function
        delegate string ReadInput();

        /// delegate steps
        /// 1. define the delegate method data type based on the method signature
        ///         delegate double MathFunction(double n1, double n2);
        /// 2. declare the delegate method variable
        ///         MathFunction processDivMult;
        /// 3. point the variable to the method that it should call
        ///         processDivMult = new MathFunction(Multiply);
        /// 4. call the delegate method / add the delegate method to the object's event handler
        ///         nAnswer = processDivMult(n1, n2);
        ///         timer.Elapsed += TimesUp;
        public static void Main()
        {

            ReadInput readInput;
            readInput = new ReadInput(Console.ReadLine);

            string userInput = readInput();


        }
    }
}