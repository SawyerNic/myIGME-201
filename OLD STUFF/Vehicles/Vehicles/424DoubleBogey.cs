namespace Vehicles
{

    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier
    {

    }

    public abstract class Car : Vehicle
    {

    }

    public abstract class Train : Vehicle
    {

    }

    public class Compact : Car, IPassengerCarrier
    {
        
    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class Pickup : Car, IPassengerCarrier
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }


}


