using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicStruct
{
    public class Stack<T> : List<T>
    {
        public Stack(Item<T> item)
        {
            Item = item;
        }
        private Item<T> LastItem { get; set; }
        public void Push(Item<T> item)
        {
            Item<T> lastItem = Item;
            while (lastItem.NextItem != null)
            {
                lastItem = lastItem.NextItem;
            }
            AddAfter(lastItem, item);

        }
        public void Pop()
        {
            Item<T> item = Item;
            while (item.NextItem != null)
            {
                item = item.NextItem;
            }
            Remove(item);
        }
        public override string ToString()
        {
            string result = "";
            var item = Item;
            while (item != null)
            {
                result += $"{item.Value} ";
                item = item.NextItem;
            }
            return result;
        }
    }
}
