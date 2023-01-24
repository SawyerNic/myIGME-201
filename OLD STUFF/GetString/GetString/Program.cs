using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        public abstract class MyClass
        {
            private String myString;

            public String MyString
            {
                set
                {
                    myString = Console.ReadLine();
                }
                get
                {
                    return myString;
                }

            }


            public virtual String GetString()
            {

                return myString;
            }

        }


        public class MyDerivedClass : MyClass
        {

            public override String GetString()
            {

               return MyString + " appended from derived class";
                

            }
        }

        public static void Main()
        {
            MyDerivedClass reference = new MyDerivedClass();

            Console.WriteLine(reference.GetString());

        }
    }
}
