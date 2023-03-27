using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 0;
            SortedList<(double, double, double), double> tupleList = new SortedList<(double, double, double), double>();

            for (double w = -2; w <= 0; w += .2)
            {
                for (double y = -1; y <= 1; y += .1)
                {
                    for (double x = 0; x <= 4; x += .1)
                    {
                        z = 4 * Math.Round(Math.Pow(y, 3),1) + 2 * Math.Round(Math.Pow(x, 2),1) - 8 * w + 7;
                        z = Math.Round(z, 3);
                        tupleList.Add((w, x, y), z);
                        Console.WriteLine(z);
                    }
                }
            }

            
        }
    }
}
