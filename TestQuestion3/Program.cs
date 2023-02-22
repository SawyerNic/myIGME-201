using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestion3
{

    internal class Program
    {
        delegate double MyDelegate(double input, int roundTo);
        static void Main(string[] args)
        {
            //create the delegate
            MyDelegate round = new MyDelegate(Math.Round);

            Console.WriteLine(round(4.582,1));
            Console.ReadLine();
        }
    }
}
