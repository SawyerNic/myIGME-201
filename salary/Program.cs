using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            //prompt user for name
            Console.WriteLine("What's your name?");
            sName = Console.ReadLine();

            //use the method to compare
            if(GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congradulations!");
                Console.WriteLine("New salary: " + dSalary);
            }
            else
            {
                Console.WriteLine("bye");
            }
            Console.ReadLine();

        }
        
        static bool GiveRaise(string name, ref double salary)
        {
            if (name.CompareTo("Sawyer") == 0)
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
