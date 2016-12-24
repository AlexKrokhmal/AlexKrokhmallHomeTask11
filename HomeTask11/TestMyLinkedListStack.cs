using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    public class TestMyLinkedListStack
    {
        public void TestTheMyLinkedListStack()
        {
            var newStack = new MyLinkeListStack<int>(7);

            newStack.Print();

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(1);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(2);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(3);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(4);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(5);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(6);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(7);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(8);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(9);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(-1);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(-2);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(-3);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(-4);
            newStack.Print();
            Console.WriteLine("-----------------");
        }

    }

}
