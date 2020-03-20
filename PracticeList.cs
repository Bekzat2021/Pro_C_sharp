using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class PracticeList<T>
    {
        private T[] items;

        public PracticeList()
        {
            items = new T[0];
        }

        public T ReturnAtIndex(int index)
        {
            return items[index];
        }

        public void AddItem(T newItem)
        {
            T[] newItems = new T[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            newItems[newItems.Length - 1] = newItem;

            items = newItems;
        }
    }
}
