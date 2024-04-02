using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2sem
{
    public partial class BlockThree
    {
        //Matula==================================================

        public int[][] DestroyRows(int[][] jaggedArray, int K1, int K2)
        {
            if (K1 >= 0 && K1 < jaggedArray.Length && K2 >= 0 && K2 < jaggedArray.Length)
            {
                // Знайти кількість рядків для видалення
                int countToRemove = K2 - K1 + 1;

                // Перевірити, чи є рядки для видалення
                if (countToRemove > 0)
                {
                    // Копіювання рядків після видалення
                    Array.Copy(jaggedArray, K2 + 1, jaggedArray, K1, jaggedArray.Length - K2 - 1);

                    int[][] newJaggedArray = new int[jaggedArray.Length - countToRemove][];

                    // Копіювання решти рядків
                    Array.Copy(jaggedArray, newJaggedArray, jaggedArray.Length - countToRemove);

                    return newJaggedArray;
                }
                else
                {
                    return jaggedArray;
                }
            }
            else
            {
                return jaggedArray;
            }
        }
    }
}
