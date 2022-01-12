using System;

namespace DinamicStruct
{
    public class Item<T>
    {
        public T Value { get; set; }
        public Item<T> ?NextItem { get; set; }
        public Item<T> ?PastItem { get; set; }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
   
}
