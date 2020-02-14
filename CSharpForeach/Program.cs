using System;
using System.Collections.Generic;

namespace CSharpForeach
{
    class MyType
    {
        private List<int> list = new List<int>();
        public object Current { get { return list[current_index]; } }
        private int current_index;

        public MyType()
        {
            current_index = -1;
        }
        public void Add(int item)
        {
            list.Add(item);
        }

        public MyType GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            current_index++;
            return current_index < list.Count;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var mytype = new MyType();
            mytype.Add(1);
            mytype.Add(2);

            foreach (var item in mytype)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Done...");
        }
    }
}
