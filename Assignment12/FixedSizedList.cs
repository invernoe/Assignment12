using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class FixedSizeList<T>
    {
        private T[] array;
        private int count = 0;

        public FixedSizeList(int capacity)
        {
            array = new T[capacity];
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                throw new Exception("list is full");
            }

            array[count++] = item;
        }

        public T Get(int index)
        {
            if (index >= count)
                throw new IndexOutOfRangeException("index out of bounds");

            return array[index];
        }
    }
}
