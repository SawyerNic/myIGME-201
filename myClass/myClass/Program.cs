using System;

namespace myClass
{
    //myClass
    public class MyClass
    {
        //local string myString
        private string myString;

        public string MyString
        {
            set
            {
                myString = value;
            }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

    //class derived from MyClass
    public class MyDerivedClass : MyClass
    {
        //derived string
        private string myDerivedString;

        public string MyDerivedString
        {
            set
            {
                myDerivedString = value;
            }
        }

        public override string GetString()
        {
            return myDerivedString;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //instantiate a derived object
            MyDerivedClass derived = new MyDerivedClass();

            //set the string value
            derived.MyDerivedString = "(output from the derived class)";

            //output the string to the console
            Console.WriteLine(derived.GetString());
        }
    }
}
