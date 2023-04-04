namespace PhoneClass
{

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public abstract int Connect();
        public abstract int Disconnect();

    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }

        public override int Connect()
        {
            throw new NotImplementedException();
        }

        public override int Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }

        public override int Connect()
        {
            throw new NotImplementedException();
        }

        public override int Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel()
        {

        }

        public static bool operator ==(Tardis left, Tardis right)
        {
            if (left.whichDrWho == 10 && right.whichDrWho == 10)
            {
                return left.whichDrWho == right.whichDrWho;
            }
            else if (left.whichDrWho == 10)
            {
                return left.whichDrWho > right.whichDrWho;
            }
            else if (right.whichDrWho == 10)
            {
                return right.whichDrWho > left.whichDrWho;
            }

            return left.whichDrWho == right.whichDrWho;
        }

        public static bool operator !=(Tardis left, Tardis right)
        {
            if (left.whichDrWho == 10)
            {
                return left.whichDrWho > right.whichDrWho;
            }
            else if (right.whichDrWho == 10)
            {
                return right.whichDrWho > left.whichDrWho;
            }

            return left.whichDrWho != right.whichDrWho;
        }

        public static bool operator <(Tardis left, Tardis right)
        {
            if (left.whichDrWho == 10)
            {
                return left.whichDrWho > right.whichDrWho;
            }
            else if (right.whichDrWho == 10)
            {
                return right.whichDrWho > left.whichDrWho;
            }

            return left.whichDrWho < right.whichDrWho;
        }

        public static bool operator >(Tardis left, Tardis right)
        {
            if (left.whichDrWho == 10)
            {
                return left.whichDrWho > right.whichDrWho;
            }
            else if (right.whichDrWho == 10)
            {
                return right.whichDrWho > left.whichDrWho;
            }

            return left.whichDrWho > right.whichDrWho;
        }

        public static bool operator <=(Tardis left, Tardis right)
        {
            if (left.whichDrWho == 10)
            {
                return left.whichDrWho > right.whichDrWho;
            }
            else if (right.whichDrWho == 10)
            {
                return right.whichDrWho > left.whichDrWho;
            }
            return left.whichDrWho <= right.whichDrWho;
        }

        public static bool operator >=(Tardis left, Tardis right)
        {
            return left.whichDrWho >= right.whichDrWho;
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }

}