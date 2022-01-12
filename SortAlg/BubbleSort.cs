using System;

namespace SortAlg
{
    public class BubbleSort
    {
        public static int[] Sort(int[] numbers) // get an unsorted array as input
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                }
            }
            return numbers;
        }

    }
}
