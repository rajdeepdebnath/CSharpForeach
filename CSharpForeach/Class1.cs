//using System;
//using System.Collections.Generic;

//namespace CSharpForeach
//{
//    class MyList
//    {
//        private List<int> list = new List<int>();
//        public object Current { get { return list[index]; } }
//        private int index;

//        public MyList()
//        {
//            index = -1;
//        }

//        public void Add(int item)
//        {
//            list.Add(item);
//        }
//        public int Count()
//        {
//            return list.Count;
//        }

//        public MyList GetEnumerator()
//        {
//            return this;
//        }

//        public bool MoveNext()
//        {
//            index++;
//            var check_index = index < this.list.Count;
//            return check_index;
//        }

//        public void Reset()
//        {
//            this.list = new List<int>();
//        }
//    }
//    class Program1
//    {
//        static void Main1(string[] args)
//        {
//            var mylist = new MyList();
//            mylist.Add(1);
//            mylist.Add(2);

//            foreach (var item in mylist)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("Done...");
//        }
//    }
//}
