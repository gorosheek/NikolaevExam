
namespace SortAlg
{
    public class CocktailSort
    {
        public static int[] Sort(int[] numbers) // get an unsorted array as input
        {
            for (int k = 0; k < numbers.Length; k++)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    int temp;
                    if (numbers[i - 1] > numbers[i])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                for (int j = numbers.Length; j < 1; j--)
                {
                    if (numbers[j] > numbers[j - 1])
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
