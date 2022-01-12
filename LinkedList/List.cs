using System;
using System.Collections;
using System.Threading.Tasks;

namespace DinamicStruct
{
    public class List<T> : IEnumerable
    {
        public List()
        {
            Count = 0;
        }
        public List(Item<T> item)
        {
            Item = item;
            Count = 1;
        }
        public Item<T> Item { get; set; }
        public int Count { get; set; }
        public void AddBefore(Item<T> oldItem, Item<T> newItem)   // oldItem.LastItem    newItem     oldItem     
        {
            if (oldItem.PastItem != null)
                oldItem.PastItem.NextItem = newItem;
            newItem.PastItem = oldItem.PastItem;
            newItem.NextItem = oldItem;
            oldItem.PastItem = newItem;
        }
        public void AddAfter(Item<T> oldItem, Item<T> newItem)    
        {  
            if (oldItem.NextItem != null)
                oldItem.NextItem.PastItem = newItem;
            oldItem.NextItem = newItem;
            newItem.PastItem = oldItem;
            Count++;

        }
        public void Remove(Item<T> item)  
        {
            if(item.NextItem != null)
                item.NextItem.PastItem = item.PastItem;
            if (item.PastItem != null)
                item.PastItem.NextItem = item.NextItem;
            Count--;
        }
        public IEnumerator GetEnumerator()
        {
            var item = Item;
            if (item.PastItem != null)
                yield return item.PastItem;
            while (item != null)
            {
                yield return item;
                item = item.NextItem;
            }
        }
        
    }
}
