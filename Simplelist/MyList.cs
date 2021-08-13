using System.Collections.Generic;
using System.Collections;
using System;

namespace Simplelist
{
    public class MyList<T>
    {
        public int Capacity   {get;set;}
        private T[] Items;
        public MyList()
        {
            Items = new T[10];
        }
        private void EnsureCapacity() 
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize );
        }
        public void Add(T Data) {
            if (Capacity ==Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = Data;
        }
        public T GetData (int idx)
        {
            if (idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException($"Index {idx}, Capacity {Capacity}");
            }
            return (T)Items[idx];
        }
    }
}