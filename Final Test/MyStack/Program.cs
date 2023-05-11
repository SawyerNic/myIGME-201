using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MyStack
    {
        private List<int> stackList;

        public MyStack()
        {
            stackList = new List<int>();
        }

        public void Push(int n)
        {
            stackList.Add(n);
        }

        public int Pop()
        {
            if (stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = stackList.Count - 1;
            int poppedElement = stackList[lastIndex];
            stackList.RemoveAt(lastIndex);
            return poppedElement;
        }

        public int Peek()
        {
            if (stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return stackList[stackList.Count - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(15);

            Console.WriteLine(myStack.Pop()); // Output: 15
            Console.WriteLine(myStack.Peek()); // Output: 10

            Console.ReadLine();
        }
    }
}
