using System;
using System.Collections.Generic;

namespace Generic
{
    class GenericProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BusinessClass<string> things = new BusinessClass<string>();
            things.AddItem("10");
            foreach (var thing in things.items)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("reomoved one is : {0}", things.RemoveItem());

        }
    }
    public class BusinessClass<T> where T:class
    //public class BusinessClass<T> 
    {
        private int int_counter = 0;
        public Queue<T> items = new Queue<T>();
        public void AddItem(T thing)
        {
            if (items.Count < 10)
            {
                items.Enqueue(thing);
                Console.WriteLine("{0} is added", thing);
            }
            else
            {
                items.Dequeue();
                items.Enqueue(thing);
                Console.WriteLine("{0} is added with delete", thing);
            }
        }
        public T RemoveItem()
        {
            return items.Dequeue();
        }
    }
}
