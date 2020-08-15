using System;
using System.Collections.Generic;

namespace Generic
{
    class GenericProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BusinessValueClass<int> things = new BusinessValueClass<int>();
            things.AddItem(10);
            things.AddItem(15);
            things.AddItem(12);
            int i = 1;
            Console.WriteLine("Get one of [{1}] is : {0}", things.GetItem(i), i);
            things.GetSelectItem();

        }
    }
    public class BusinessValueClass<T> where T: struct
   
    {
        
        private List<T> items = new List<T>();
        public void AddItem(T thing)
        {            
            items.Add(thing);
            Console.WriteLine("{0} is added", thing);                        
        }
        public T GetItem(int i)
        {
            return items[i];
        }
        public void GetSelectItem()
        {
            items.Sort();
            items.Reverse();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
