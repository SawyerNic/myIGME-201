using System;
using PhoneClass;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth booth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(booth);
            
        }

        static void UsePhone(object obj)
        {
            if(obj is PhoneBooth)
            {
                PhoneBooth booth = obj as PhoneBooth;
                booth.OpenDoor();
            }
            if(obj is Tardis)
            {
                Tardis tardis = obj as Tardis;
                tardis.TimeTravel();
            }
            if (obj is Tardis || obj is PhoneBooth)
            {
                PhoneInterface phone = obj as PhoneInterface;
                phone.MakeCall();
                phone.HangUp();
            }
        }

    }
}
