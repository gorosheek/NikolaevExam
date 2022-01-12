using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{                                              //   0   1   2  3   4   5  6   7   8    9          0   1  2  3   4   5  6   7   8    9
    public class ShellSort                     // [ 36, 64, 6, 96, 37, 1, 87, 25, 30, 100 ]  -> [ 1, 64, 6, 30, 37, 36, 87, 25, 96, 100 ]
    {                                       // -> [ 1, 25, 6, 30, 37, 36, 87, 64, 96, 100 ]  -> [ 1, 6, 25, 30, 36, 37, 64, 87, 96, 100 ]
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers;
            }
            int step = numbers.Length / 2;
            while (step > 0) 
            {
                for (int i = 0; i < step; i++)                                                              // группы по шагам
                {
                    int temp = numbers[step + i];
                    for (int j = i; j < numbers.Length; j += step)                                         // по элементам в одной группе
                    {
                        int k;
                        for (k = j; k > -1; k -= step)                                                     // сортировка элемента в своей группе
                        {
                            if (temp < numbers[k])
                            {
                                (numbers[k], numbers[k + step]) = (numbers[k + step], numbers[k]);
                            }
                            
                        }
                        if (j + step * 2 < numbers.Length)
                            temp = numbers[j + step * 2];
                        else
                            break;
                    }
                }
                step /= 2;
            }
            return numbers;
        }
    }
}






//for (int i = 0; i < step; i++)
//{
//    for (int j = i; j < numbers.Length; j += step)
//    {
//        if (j + step * 2 < numbers.Length)
//        {
//            for (int k = numbers.Length - step - 2; k > -1; k -= step) // проверка есть ли еще элемент через шаг
//            {
//                if (numbers[k + step] < numbers[k])  // сравнение двух "соседних" элементов
//                    (numbers[k + step], numbers[k]) = (numbers[k], numbers[k + step]);
//            }
//        }
//        else
//        {
//            if (numbers[j + step] < numbers[j])  // сравнение двух "соседних" элементов
//                (numbers[j + step], numbers[j]) = (numbers[j], numbers[j + step]);
//            break;

//        }


//    }
//}
