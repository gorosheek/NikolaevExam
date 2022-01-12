using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{                                                                
    public class QuickSort                                   
    {
        public static int[] Sort(int[] numbers, int rightIndex, int leftIndex = 0)
        {                                                              
            if (rightIndex - leftIndex < 1)                            
                return numbers;                                        

            int arrayLeftEdge = leftIndex;       
            int arrayRightEdge = rightIndex;       
                                                 
            int pivotIndex = (rightIndex + leftIndex) / 2;


            while (leftIndex <= rightIndex)
            {
                if (numbers[leftIndex] >= numbers[pivotIndex] && numbers[rightIndex] <= numbers[pivotIndex])
                {
                    (numbers[leftIndex], numbers[rightIndex]) = (numbers[rightIndex], numbers[leftIndex]);
                    leftIndex++;
                    rightIndex--;                       
                }                                       
                else                                    
                {                                       
                    if (numbers[leftIndex] < numbers[pivotIndex])
                        leftIndex++;
                    if (numbers[rightIndex] > numbers[pivotIndex])
                        rightIndex--;
                }
            }

            numbers = Sort(numbers, rightIndex, arrayLeftEdge);  // left

            numbers = Sort(numbers, arrayRightEdge, leftIndex); // right
                return numbers;
        }
    }
}
