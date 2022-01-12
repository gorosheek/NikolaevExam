using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{
    public class BinarySearch
    {
        public static int Search(int[] numbers, int number)
        {
            int[] tempArr = new int[numbers.Length / 2];

            int middle = numbers[numbers.Length / 2];
            if (middle == number)
                return middle;

            if (middle > number)
            {
                for (int i = 0; i < tempArr.Length; i++)
                {
                    tempArr[i] = numbers[i];
                }
            }
            else
            {
                int k = 0;
                for (int i = numbers.Length / 2; k < tempArr.Length; i++)
                {
                    if (numbers.Length % 2 != 0)
                        tempArr[k] = numbers[i + 1];
                    else
                        tempArr[k] = numbers[i];
                    k++;
                }
            }
            int searchNumber = 0;
            if (numbers.Length > 1)
                searchNumber = Search(tempArr, number);
            if (numbers.Length == 1 && searchNumber != number)
                throw new Exception("Not found");
            return searchNumber;
        }
        
    }
}
