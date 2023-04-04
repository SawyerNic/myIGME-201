using System;
using Hobbies;

namespace Hobbies
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer soccer = new Soccer();
            soccer.equipment = "Soccer ball";
            soccer.BuyEquipment = 2;

            Lacrosse lacrosse = new Lacrosse();
            lacrosse.equipment = "Lacrosse ball";
            lacrosse.BuyEquipment = 1;

            MyMethod(soccer);
            MyMethod(lacrosse);
        }

        static void MyMethod(object obj)
        {
            if (obj is Soccer)
            {
                Sports sport = (Soccer)obj;
                Console.WriteLine($"Playing {sport.GetType().Name} with {sport.equipment} and {sport.BuyEquipment} items of equipment.");
            }
            else
            {
                Console.WriteLine("Invalid argument passed to MyMethod.");
            }
        }
    }
}
