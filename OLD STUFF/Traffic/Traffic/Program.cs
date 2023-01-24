
using Vehicles;
using System;

namespace Traffic
{

    class Program
    {

        static void AddPassenger(IPassengerCarrier vehichle)
        {
           vehichle.LoadPassenger();
           vehichle.ToString();
        }

    }
}