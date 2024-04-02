using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2sem
{
    public partial class BlockOne
    {
        //Matula==================================================
        public void PrintSimpleArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        public int[] DoBlock1byMatula(int[] array)
        {
            // Беру до уваги, щоб кількість елементів в новому масиві не = 0
            // та щоб рахувався нульовий елемент в інераціях циклу
            int newLength = (array.Length + 1) / 2;
            int[] newArray = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = array[i * 2];
            }

            return newArray;
        }
    }
}
