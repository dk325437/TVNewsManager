using System;
using System.Collections;

namespace TVNewsManager.Collections
{
    [Serializable]
    public class MyList<T> : IEnumerable
    {
        private T[] items;
        private int count;

        public int Count { get { return count; } }

        public MyList()
        {
            items = new T[10];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count) return;

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                items[index] = value;
            }
        }

        public T[] ToArray()
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = items[i];
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
    }
}
