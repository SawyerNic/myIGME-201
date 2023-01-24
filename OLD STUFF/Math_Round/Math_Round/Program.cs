using System;


namespace MathPowManual
{
    class Program
    {

        delegate double MathRound(double x);

        public static void Main()
        {
            MathRound round = new MathRound(Math.Round);
            double rounded = round(6.9);
            Console.WriteLine(rounded);
            Console.ReadLine();

        }

    }
}

