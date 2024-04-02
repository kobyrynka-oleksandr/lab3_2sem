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
        public static void DestroyRows(int[][] jaggedArray, int k1, int k2)
        {
            // Перевірка діапазону
            if (k1 < 0 || k2 < 0 || k1 > k2 || k2 >= jaggedArray.Length)
            {
                return;
            }

            // Зсув хвоста
            for (int i = k2 + 1; i < jaggedArray.Length; i++)
            {
                jaggedArray[i - k2 - 1] = jaggedArray[i];
            }

            // Зменшення Length
            Array.Resize(ref jaggedArray, jaggedArray.Length - (k2 - k1 + 1));
        }
        //Matula==================================================

    }
}
