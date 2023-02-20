using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary2
{
    struct Employee
    {
        public string sName;
        public double dSalary = 30000;
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Employee employee = new Employee();
        //prompt user for name
        Console.WriteLine("What's your name?");
            employee.sName = Console.ReadLine();

            //use the method to compare
            if (GiveRaise(employee.sName, ref employee.dSalary))
            {
                Console.WriteLine("Congradulations!");
                Console.WriteLine("New salary: " + employee.dSalary);
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