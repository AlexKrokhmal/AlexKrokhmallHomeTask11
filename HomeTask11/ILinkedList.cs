using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    public interface ILinkedList<T> : IPrintable
    {
        void Add(T valueToAdd);
        void Remove(int positionToRemove);
        T Get(int positionToGet);
        void Insert(T valueToInsert, int positionToInsert);        
    }
}
