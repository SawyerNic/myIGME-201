namespace PE14
{
    class Program
    {

        

        class Class1 : IFace
        {
            void doSomething()
            {
                Console.WriteLine("Class1");
            }
        }

        class Class2 : IFace
        {
            void doSomething()
            {
                Console.WriteLine("Class2");
            }
        }

        interface IFace
        {
            void doSomething()
            {
                Console.WriteLine("Interface");
            }
        }

        public static void MyMethod(object Object)
        {
            
        }

        public static void Main()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            MyMethod(class1);
            MyMethod(class2);
            
        }
    }
}