using SortAlg;
using DinamicStruct;
namespace Console
{
    using System;
    using Tester.Meta.Testers;

    internal class Program
    {
        static void Main()
        {
            //TimeTester test = new TimeTester();
            //for (int i = 1; i < 1001; i++)
            //{
            //    int[] arr = GetRandom(i);
            //    test.Test(() => InsertionSort.Sort(arr), 5, "test");
            //}
            //test.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test");

            //int[] arr = TreeSort.Sort(new int[] { 8, 4, 6, 12, 10, 7, 11, 9, 5, 14, 13, 2, 3, 1, 15 });
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(BinarySearch.Search(arr, arr[i]));
            //}

            //try
            //{
            //    BinarySearch.Search(arr, 15);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Item<int> item1 = new Item<int> { Value = 5 };
            //List<int> list = new List<int>(item1);
            Item<int> item2 = new Item<int> { Value = 6 };
            //Item<int> item3 = new Item<int> { Value = 7 };
            //list.AddBefore(item1,item2);
            //list.AddAfter(item1, item3);
            Stack<int> stack = new Stack<int>(item1);
            stack.Push(item2);
            foreach (var i in stack)
            {
                Console.WriteLine($"Push: {i.ToString()}");
            }
            Console.WriteLine(stack.ToString());
            stack.Pop();
            foreach (var i in stack)
            {
                Console.WriteLine($"Pop: {i.ToString()}");
            }

            //list.Remove(item2);
            //foreach (var i in list)
            //{
            //    Console.WriteLine(i.ToString());
            //}
        }
        static int[] GetRandom(int ii)
        {
            Random random = new Random();
            int[] arr = new int[ii];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            return arr;
        }
    }
}
