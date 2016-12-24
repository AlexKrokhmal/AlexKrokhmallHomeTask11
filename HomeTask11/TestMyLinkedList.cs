using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    public class TestMyLinkedList
    {
        public void TestTheLinkedList()
        {
            int i = 0;

            Console.WriteLine("--------------------------------{0}", i++);

            var newLinkedList = new MyLinkedList<int>(8);
            newLinkedList.Print();
            Console.WriteLine(newLinkedList.Get(0));                       

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(5);
            newLinkedList.Print();
            Console.WriteLine(newLinkedList.Get(0));
            Console.WriteLine(newLinkedList.Get(1));
            
            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(6);
            newLinkedList.Print();

            Console.WriteLine(newLinkedList.Get(0));
            Console.WriteLine(newLinkedList.Get(1));
            Console.WriteLine(newLinkedList.Get(2));

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(7);
            newLinkedList.Print();

            Console.WriteLine(newLinkedList.Get(0));
            Console.WriteLine(newLinkedList.Get(1));
            Console.WriteLine(newLinkedList.Get(2));
            Console.WriteLine(newLinkedList.Get(3));

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(8);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(3);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(9);
            newLinkedList.Print();

            Console.WriteLine(newLinkedList.Get(0));
            Console.WriteLine(newLinkedList.Get(1));
            Console.WriteLine(newLinkedList.Get(2));
            Console.WriteLine(newLinkedList.Get(3));

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(2);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(-1);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(-5);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(-8);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Insert(-6, 1);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Insert(-7, 3);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Insert(-7, 2);
            newLinkedList.Print();

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Insert(-4, 0);
            newLinkedList.Print();

            Console.WriteLine(newLinkedList.Get(0));
            Console.WriteLine(newLinkedList.Get(1));
            Console.WriteLine(newLinkedList.Get(2));
            Console.WriteLine(newLinkedList.Get(3));

            Console.WriteLine("--------------------------------{0}", i++);

            newLinkedList.Add(-9);
            newLinkedList.Print();

            newLinkedList.Add(-10);
            newLinkedList.Print();

            newLinkedList.Add(-11);
            newLinkedList.Print();

            newLinkedList.Add(12);
            newLinkedList.Print();

            newLinkedList.Insert(2, 0);
            newLinkedList.Print();

            newLinkedList.Remove(8);
            newLinkedList.Print();

            newLinkedList.Remove(7);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            newLinkedList.Remove(0);
            newLinkedList.Print();

            Console.WriteLine();
        }



    }
}
