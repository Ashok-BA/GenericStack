////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace GenericStack
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            Stack<string> st = new Stack<string>();
////            st.Push("Ganesh");
////            st.Push("Rakesh");
////            st.Push("Ramesh");
////            st.Push("Suresh");
////            Console.WriteLine("Elements in Stack is:-");
////            foreach(var item in st)
////            {
////                Console.WriteLine(item);
////            }

////            Console.WriteLine("Pop an Element:-" + st.Pop());
////            foreach(var item in st)
////            {
////                Console.WriteLine(item);
////            }

////            Console.WriteLine("Peek an Element:-" + st.Peek());

////            Console.WriteLine("Count:-" + st.Count);

////            st.Clear();
////            Console.WriteLine("Count:-" + st.Count());
////        }
////    }
////}
