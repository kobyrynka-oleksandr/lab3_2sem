using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3GIT
{
    public class Belitskyi
    {
        public static void Block1(ref int[] array)
        {

            int max = array[0]; 
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            if (max % 2 == 0)
            {
                int newLength = array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        newLength++;
                    }
                }
                Array.Resize(ref array,newLength);
                for (int i = array.Length - 2; i >= 0; i--)
                {
                    if (array[i] == max)
                    {
                        for(int j = newLength - 1; j > i + 1; j--)
                        {
                            array[j] = array[j-1];
                        }
                        array[i] /= 2;
                        array[i + 1] = array[i];    
                    }
                }
            }
        }
        public static void Block3(ref int[][] jaggedArray) // 12 варіант
        {

            int maxElement = int.MinValue;
            int maxRowIndex = -1;
            int nullcount = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray[i] == null)
                {
                    nullcount++;
                    continue;
                }
                int currentMaxInRow = jaggedArray[i].Max();
                if (currentMaxInRow >= maxElement)
                {
                    maxElement = currentMaxInRow;
                    maxRowIndex = i;
                }
            }
            if (nullcount == jaggedArray.Length)
            {
                Console.WriteLine("Всі рядки масиву дорівнюють null. Визначити максимальний елемент в рядку - неможливо. Повернено початковий масив.");
                return;
            }
            Array.Resize(ref jaggedArray, jaggedArray.Length + 1);
            for (int i = jaggedArray.Length - 1; i > maxRowIndex; i--)
            {
                jaggedArray[i] = jaggedArray[i - 1];
            }
            jaggedArray[maxRowIndex] = null;
        }
    }
}

