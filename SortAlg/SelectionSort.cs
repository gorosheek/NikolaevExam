using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{
    public class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
            int count = numbers.Length;
            for (int i = numbers.Length - 1; i >= 0; i--)  //for replacement
            {
                int tempIndex = 0;
                int max = 0;
                for (int j = 0; j < count; j++)  // search max element
                {
                    if (numbers[j] > max)
                    {
                        max = numbers[j];
                        tempIndex = j;
                    }
                }
                numbers[tempIndex] = numbers[i];
                numbers[i] = max;
                count--; 
            }
            return numbers;
        }
    }
}
