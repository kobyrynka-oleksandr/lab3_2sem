using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lab3_2sem
{
    static void Main()
    {
        Console.WriteLine("Choose block:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 2:
                Block2a();
                break;
            case 3:
                Block2b();
                break;
            case 4:
                Block4();
                break;
            default:
                Console.WriteLine("u make mistake");
                break;
        }
    }
    static void Block2a()
    {
        long memorybeforeBlock2 = GC.GetTotalMemory(false);
        Console.WriteLine("Enter number of rows:");
        int n = int.Parse(Console.ReadLine());
        int[][] array = new int[n + 1][];
        for (int i = 0; i <= n; i++)
        {
            array[i] = new int[n + 1];
        }
        FillArray(ref array, n);
        PrintArrayFor2Block(array);
        long memoryafterBlock2 = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory used in Block 2a:  {(memoryafterBlock2 - memorybeforeBlock2)}\n");
    }
    static void Block2b()
    {
        long memorybeforeBlock2b = GC.GetTotalMemory(false);
        Console.WriteLine("Enter number of rows:");
        int n = int.Parse(Console.ReadLine());
        int[][] arraya = new int[n + 1][];
        int k = FindMaxNumber(n);
        int[][] arrays = new int[k][];
        for (int i = 0; i < k; i++)
        {
            arrays[i] = new int[n + 1];
        }
        FillArray2(ref arrays, n);
        for (int i = 0;i<n; i++)
        {
            int number = SumOfDigits(i);
            arraya[i] = arrays[number];
        }
        PrintArrayFor2Block(arraya);
        //for (int i = 0; i < arraya.Length-1; i++)
        //{
        //    Console.Write($"{i} : ");
        //    int number = SumOfDigits(i);
        //    for (int j = 0; j < arrays[number].Length; j++)
        //    {
        //        if(arrays[number][j]!=0)
        //        Console.Write($"{arrays[number][j]} ");
        //    }
        //    Console.WriteLine();
        //}
        long memoryafterBlock2b = GC.GetTotalMemory(false);
        Console.WriteLine("Memory used in Block 2b: " + (memoryafterBlock2b - memorybeforeBlock2b));
    }
    static void PrintArrayFor2Block(int[][] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{i} : ");
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] != 0)
                {
                    Console.Write(array[i][j] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void FillArray2(ref int[][] array, int n)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int placeInArray = 0;
            for (int j = 1; j <= n; j++)
            {
                if (j % i == 0)
                {
                    array[i][placeInArray] = j;
                    placeInArray++;
                }
            }
        }
    }
    static void FillArray(ref int[][] array, int n)
    {
        for (int i = 1; i < n; i++)
        {
            int sumOfDigits = SumOfDigits(i);
            int placeInArray = 0;
            for (int j = 1; j <= n; j++)
            {
                if (j % sumOfDigits == 0)
                {
                    array[i][placeInArray] = j;
                    placeInArray++;
                }
            }
        }
    }
    static int FindMaxNumber(int n)
    {
        int maxValue = 0;
        for (int i = 1; i <= n; i++)
        {
            int tens = i / 10;
            int units = i % 10;
            int value = tens + units;

            if (value > maxValue)
            {
                maxValue = value;
            }
        }
        return maxValue+1;
    }
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    static void Block4()
    {
        Console.WriteLine("Enter rows");
        int rows = int.Parse(Console.ReadLine());
        List<List<int>> arrayA = new List<List<int>>();
        ArrayInput(arrayA, rows);
        Console.WriteLine();
        Console.WriteLine("Sorted array A:");
        PrintArrayFor4BlockJagged(arrayA);
        List<List<int>> arrayB = new List<List<int>>();
        for (int i = 0; i < arrayA.Count; i++)
        {
            arrayB.Add(new List<int> { arrayA[i][0], arrayA[i][arrayA[i].Count - 1] });
        }
        Console.WriteLine("Array B");
        PrintArrayFor4BlockJagged(arrayB);
    }
    static void ArrayInput(List<List<int>> list, int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            List<int> templist = Console.ReadLine().Split().Select(int.Parse).ToList();
            templist.Sort();
            list.Add(templist);
        }
    }
    static void PrintArrayFor4BlockJagged(List<List<int>> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Count; j++)
            {
                Console.Write(list[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}