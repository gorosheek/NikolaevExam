using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg                        
{                                             
    public class InsertionSort    
    {                                        
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length < 2)
                return numbers;
            int temp = numbers[1];
            for (int i = 0; i < numbers.Length - 1; i++)
            { 
                if (temp > numbers[i])                         //сравнение выделенного элемента с его соседом слева
                {
                    if (i != numbers.Length - 2)               
                        temp = numbers[i + 2];                 //замена выбранного элемента на новый
                    else
                        break;
                }
                else
                {
                    int j;
                    for (j = i; j > -1; j--)
                    {
                        if (temp < numbers[j])
                            numbers[j + 1] = numbers[j];
                        else
                            break;
                    }
                    numbers[j + 1] = temp;
                    if (i >= numbers.Length - 2)
                        break;
                    else
                        temp = numbers[i + 2];
                }
                
            }
            return numbers;
        }
    }
}
