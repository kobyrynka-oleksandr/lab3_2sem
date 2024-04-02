using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2sem
{
    public class Kobyrynka
    {
        public static void Block1(ref int[] array) // 15 варіант
        {
            int countEvenElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    countEvenElements++;
            }
            if (countEvenElements > 0)
            {
                Array.Resize(ref array, array.Length + countEvenElements);

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        for (int j = array.Length - countEvenElements - 1; j > i; j--)
                        {
                            array[j + 1] = array[j];
                        }
                        array[i + 1] = 0;
                        countEvenElements--;
                        i++;
                    }

                    if (countEvenElements == 0)
                        break;
                }
            }
            else
                Console.WriteLine("Масив не містить парних елементів.");
        }
        public static void Block3(ref int[][] array) // 7 варіант
        {
            int[][] b = new int[array.Length][];
            int count = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                if (array[i] != null)
                {
                    b[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref b, count);
            array = b;
        }
    }
}
