using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Potaichuk
{
    public static void Block1(ref int[] array)
    {
        int smallest = 0;
        int biggest = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[biggest])
                biggest = i;
            if (array[i] < array[smallest])
                smallest = i;
        }
        int[] resizearray = new int[2];
        if (smallest < biggest)
        {
            resizearray[0] = array[smallest];
            resizearray[1] = array[biggest];
        }
        else
        {
            resizearray[0] = array[biggest];
            resizearray[1] = array[smallest];
        }
        Array.Resize(ref array, resizearray.Length);
        Array.Copy(resizearray, array, resizearray.Length);
        Print1DArray(ref array);
        Console.ReadKey();
    }
    public static void Block3(ref int[][] array)
    {
        int xbiggest = 0;
        int ybiggest = 0;
        FindBiggestIndex(array, ref xbiggest, ref ybiggest);
        int[][] newarray = new int[array.GetLength(0) - 1][];
        int indextoremove = xbiggest;
        Array.Copy(array, 0, newarray, 0, indextoremove);
        Array.Copy(array, indextoremove + 1, newarray, indextoremove, array.GetLength(0) - indextoremove - 1);
        Console.WriteLine("Масив після видалення рядка:");
        Print2DArray(newarray);
        Console.ReadKey();

    }
    public static void Print1DArray(ref int[] array)
    {
        foreach (int i in array)
            Console.Write(i + " ");
    }
    public static void Print2DArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
            {
                Console.WriteLine();
                continue;
            }
            Console.WriteLine(string.Join(" ", array[i]));
        }
    }
    public static void FindBiggestIndex(int[][] array, ref int xbiggest, ref int ybiggest)
    {
        bool foundValidValue = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                continue;
            for (int j = 0; j < array[i].Length; j++)
            {
                if (!foundValidValue || array[i][j] > array[xbiggest][ybiggest])
                {
                    xbiggest = i;
                    ybiggest = j;
                    foundValidValue = true;
                }
            }
        }
    }
}