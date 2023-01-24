using System;

namespace TestQuestion12
{

    class Program
    {


        static string sName;
        static double dSalary = 30000;

        static bool GiveRaise(string name, ref double salary)
        {
            if (sName.Equals(name))
            {
                dSalary += 19999.99;
                Console.WriteLine($"Congratulations!, your salary has increased to {dSalary}");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {

            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();
            GiveRaise(sName, ref dSalary);
            
        }

    }
    
    
}