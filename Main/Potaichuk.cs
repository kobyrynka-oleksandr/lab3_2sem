﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Potaichuk
{
    public static void Block1(ref int[] array)
    {
        int smallest = array[0];
        int smallestIndex = 0;
        int biggest = array[0];
        int biggestIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= biggest)
            {
                biggest = array[i];
                biggestIndex = i;
            }
            if (array[i] < smallest)
            {
                smallest = array[i];
                smallestIndex = i;
            }
        }
        List<int> result = new List<int>();
        int startIndex = smallestIndex;
        int endIndex = biggestIndex;
        for (int i = 0; i < array.Length; i++)
        {
            if(smallestIndex<biggestIndex)
            {
                if (i <= startIndex || i >= endIndex)
                {
                    result.Add(array[i]);
                }
            }
            else
            {
                if (i >= startIndex || i <= endIndex)
                {
                    result.Add(array[i]);
                }
            }
        }
        array = result.ToArray();
    }
    public static int[][] Block3(int[][] array)
    {
        int RowOfBiggest = 0;
        int ColOfBiggest = 0;
        FindBiggestIndex(array, ref RowOfBiggest, ref ColOfBiggest);
        int[][] newarray = new int[array.GetLength(0) - 1][];
        int indextoremove = RowOfBiggest;
        Array.Copy(array, 0, newarray, 0, indextoremove);
        Array.Copy(array, indextoremove + 1, newarray, indextoremove, array.GetLength(0) - indextoremove - 1);
        return newarray;
    }
    public static void FindBiggestIndex(int[][] array, ref int RowOfBiggest, ref int ColOfBiggest)
    {
        bool foundValidValue = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                continue;
            for (int j = 0; j < array[i].Length; j++)
            {
                if (!foundValidValue || array[i][j] > array[RowOfBiggest][ColOfBiggest])
                {
                    RowOfBiggest = i;
                    ColOfBiggest = j;
                    foundValidValue = true;
                }
            }
        }
    }
}