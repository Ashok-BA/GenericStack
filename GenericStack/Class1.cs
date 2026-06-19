using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class program
    {
        static void Main(string[]args)
        {
            Stack<int> num = new Stack<int>();
            num.Push(1);
            num.Push(2);
            num.Push(3);
            num.Push(4);
            num.Push(5);
            Console.WriteLine("Elements in a stack:-");
            Console.WriteLine("Pop an Element is:" + num.Pop());
            Console.WriteLine("peek an Element is:" + num.Peek());
            Console.WriteLine("Count:" + num.Count);
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }

            num.Clear();
            Console.WriteLine("Count:" + num.Count);
        }
    }
}
