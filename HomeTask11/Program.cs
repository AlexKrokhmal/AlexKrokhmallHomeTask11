using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var newTestMyLinkedList = new TestMyLinkedList();
            newTestMyLinkedList.TestTheLinkedList();
            
            
            var newTestMyLinkedListStack = new TestMyLinkedListStack();
            newTestMyLinkedListStack.TestTheMyLinkedListStack();
            

            var newTestMyLinkedListQueue = new TestMyLinkedListQueue();
            newTestMyLinkedListQueue.TestTheMyLinkedListQueue();

            Console.ReadLine();
        }
    }
}
