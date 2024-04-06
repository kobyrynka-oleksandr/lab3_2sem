using LAB3GIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2sem
{
    public class MainMenu
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Вибiр блоку: \n1. Блок 1; \n2. Блок 3.");
                int chooseBlock = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (chooseBlock)
                {
                    case 1:
                        DoBlock1();
                        break;
                    case 2:
                        DoBlock3();
                        break;
                }
            }
        }
        public static void DoBlock1()
        {
            while (true)
            {
                Console.WriteLine("Вибiр дiї: \n1. Введення масиву; \nбудь-яке iнше число: вихiд до вибору блоку.");
                int numOfAction = int.Parse(Console.ReadLine());
                if (numOfAction != 1)
                    break;

                Console.WriteLine("Кількість елементів масиву: ");
                int numOfElements = int.Parse(Console.ReadLine());
                int[] array = new int[numOfElements];

                while (true)
                {
                    Console.WriteLine("Створення масиву: \n1. Заповнення випадковими(рандомними) елементами; \n2. Поелементне заповнення з клавiатури" +
                       "\nбудь-яке iнше число: виведення поточного стану масиву.");

                    int numOfInput = int.Parse(Console.ReadLine());
                    switch (numOfInput)
                    {
                        case 1:
                            array = RandomForOneDimensionalArray(array, numOfElements);
                            break;
                        case 2:
                            array = InputForOneDimensionalArray(array, numOfElements);
                            break;
                        default:
                            OutputForOneDimensionalArray(array);
                            break;
                    }
                    if (numOfInput == 1 || numOfInput == 2)
                        break;
                }
                Console.Clear();
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Обрати варіант для виконання; \nбудь-яке iнше число: Вивести поточний стан масиву");
                        int choose = int.Parse(Console.ReadLine());
                        if (choose == 1)
                            break;
                        else
                            OutputForOneDimensionalArray(array);
                        Console.Write("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        Console.WriteLine();
                    }

                    Console.Write("q. Виконати варіант: 15, студент: Кобиринка;" +
                        "\nw. Виконати варіант: 13, студент: Беліцький;" +
                        "\ne. Виконати варіант: 8, студент: Матула;" +
                        "\nr. Виконати варіант 10, студент: Потайчук.");
                    Console.WriteLine();
                    char chooseStudent = Console.ReadLine()[0];
                    Console.WriteLine();

                    DoSelectedTaskBlock1(chooseStudent, ref array);

                    bool exit = false;
                    while (true)
                    {
                        Console.WriteLine("1. Використати новий масив; \n2. Вивести поточний стан масиву; \n3. Очистити консоль; \nбудь-яке iнше число: використати поточний масив.");
                        int exitToArrayInput = int.Parse(Console.ReadLine());
                        if (exitToArrayInput == 3)
                        {
                            Console.Clear();
                            continue;
                        }
                        if (exitToArrayInput == 1 || exitToArrayInput == 2)
                        {
                            if (exitToArrayInput == 1)
                            {
                                exit = true;
                                break;
                            }
                            else
                            {
                                OutputForOneDimensionalArray(array);
                                Console.Write("Натисніть будь-яку клавішу, щоб продовжити...");
                                Console.ReadKey();
                                Console.WriteLine("\n");
                            }
                        }
                        else
                            break;
                    }
                    if (exit)
                    {
                        break;
                    }
                }
            }
        }
        public static int[] RandomForOneDimensionalArray(int[] array, int numOfElements)
        {
            Random random = new Random();
            for (int i = 0; i < numOfElements; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }
        public static int[] InputForOneDimensionalArray(int[] array, int numOfElements)
        {
            while (true)
            {
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (numOfElements == array.Length)
                {
                    break;
                }
                else
                    Console.WriteLine("Задана кількість елементів не співпадає зі вписаною кількістю елементів. Спробуйте ввести масив ще раз.");
            }
            return array;
        }
        public static void OutputForOneDimensionalArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
        public static void DoBlock3()
        {
            while (true)
            {
                Console.WriteLine("Вибiр дiї: \n1. Введення масиву; \nбудь-яке iнше число: вихiд до вибору блоку.");
                int numOfAction = int.Parse(Console.ReadLine());
                if (numOfAction != 1)
                    break;

                Console.WriteLine("Кількість рядків масиву: ");
                int numOfRows = int.Parse(Console.ReadLine());
                int[][] array = new int[numOfRows][];

                while (true)
                {
                    Console.WriteLine("Створення масиву: \n1. Заповнення випадковими(рандомними) елементами; \n2. Поелементне заповнення з клавiатури" +
                       "\nбудь-яке iнше число: виведення поточного стану масиву.");

                    int numOfInput = int.Parse(Console.ReadLine());
                    switch (numOfInput)
                    {
                        case 1:
                            array = RandomForJaggedArray(array, numOfRows);
                            break;
                        case 2:
                            array = InputForJaggedArray(array, numOfRows);
                            break;
                        default:
                            OutputForJaggedArray(array);
                            break;
                    }
                    if (numOfInput == 1 || numOfInput == 2)
                        break;
                }
                Console.Clear();
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Обрати варіант для виконання; \nбудь-яке iнше число: Вивести поточний стан масиву");
                        int choose = int.Parse(Console.ReadLine());
                        if (choose == 1)
                            break;
                        else
                            OutputForJaggedArray(array);
                        Console.Write("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        Console.WriteLine();
                    }

                    Console.Write("q. Виконати варіант: 7, студент: Кобиринка;" +
                        "\nw. Виконати варіант: 12, студент: Беліцький;" +
                        "\ne. Виконати варіант: 3, студент: Матула;" +
                        "\nr. Виконати варіант 8, студент: Потайчук.");
                    Console.WriteLine();
                    char chooseStudent = Console.ReadLine()[0];
                    Console.WriteLine();

                    DoSelectedTaskBlock3(chooseStudent, ref array);

                    bool exit = false;
                    while (true)
                    {
                        Console.WriteLine("1. Використати новий масив; \n2. Вивести поточний стан масиву; \n3. Очистити консоль; \nбудь-яке iнше число: використати поточний масив.");
                        int exitToArrayInput = int.Parse(Console.ReadLine());
                        if (exitToArrayInput == 3)
                        {
                            Console.Clear();
                            continue;
                        }
                        if (exitToArrayInput == 1 || exitToArrayInput == 2)
                        {
                            if (exitToArrayInput == 1)
                            {
                                exit = true;
                                break;
                            }
                            else
                            {
                                OutputForJaggedArray(array);
                                Console.Write("Натисніть будь-яку клавішу, щоб продовжити...");
                                Console.ReadKey();
                                Console.WriteLine("\n");
                            }
                        }
                        else
                            break;
                    }
                    if (exit)
                    {
                        break;
                    }
                }
            }
        }
        public static int[][] RandomForJaggedArray(int[][] array, int numOfRows)
        {
            Random random = new Random();
            for (int i = 0; i < numOfRows; i++)
            {
                int numOfElementsInRow = random.Next(0, 7);
                if (numOfElementsInRow == 0)
                {
                    array[i] = null;
                    continue;
                }
                array[i] = new int[numOfElementsInRow];
                for (int j = 0; j < numOfElementsInRow; j++)
                {
                    array[i][j] = random.Next(1, 100);
                }
            }
            return array;
        }
        public static int[][] InputForJaggedArray(int[][] array, int numOfRows)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                Console.Write($"Кількість елементів {i + 1} рядка(0 - порожній рядок): ");
                int numOfElementsInRow = int.Parse(Console.ReadLine());
                if (numOfElementsInRow == 0)
                {
                    array[i] = null;
                    continue;
                }
                int[] row;
                while (true)
                {
                    row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    if (row.Length == numOfElementsInRow)
                        break;
                    else
                        Console.WriteLine("Задана кількість елементів не співпадає зі вписаною кількістю елементів. Спробуйте ввести рядок ще раз.");
                }
                for (int j = 0; j < row.Length; j++)
                {
                    array[i] = row;
                }
            }
            return array;
        }
        public static void OutputForJaggedArray(int[][] array)
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
        public static void DoSelectedTaskBlock1(char chooseStudent, ref int[] array)
        {
            switch (chooseStudent)
            {
                case 'q':
                    Kobyrynka.Block1(ref array);
                    break;
                case 'w':
                    Belitskyi.Block1(ref array);
                    break;
                //Matula=========================================
                case 'e':
                    Console.WriteLine("Блок 1. Варіант 8. Знищити всі елементи з непарними індексами:");
                    BlockOne block1 = new BlockOne();

                    Console.WriteLine($"Введений масив:");
                    block1.PrintSimpleArray(array);

                    array = block1.DoBlock1byMatula(array);

                    Console.WriteLine("Отриманий масив після виконання блоку:");
                    block1.PrintSimpleArray(array);
                    break;
                //Matula=========================================
                case 'r':
                    Potaichuk.Block1(ref array);
                    break;
            }
        }
        public static void DoSelectedTaskBlock3(char chooseStudent, ref int[][] array)
        {
            switch (chooseStudent)
            {
                case 'q':
                    Kobyrynka.Block3(ref array);
                    break;
                case 'w':
                    Belitskyi.Block3(ref array);
                    break;
                //Matula=========================================
                case 'e':
                    Console.WriteLine("Знищити рядки, починаючи з рядка К1 і до рядка К2 (лише якщо увесь цей діапазон фактично є; якщо\r\nхоча б одного з таких рядків нема, лишити масив без змін).");
                    BlockThree block3 = new BlockThree();

                    Console.WriteLine($"Введений масив:");
                    OutputForJaggedArray(array);

                    Console.WriteLine("Введіть два числа (К1 та К2) через пробіл");
                    string input = Console.ReadLine();
                    string[] rows = input.Split(' ');

                    int k1 = int.Parse(rows[0]);
                    int k2 = int.Parse(rows[1]);

                    array = block3.DestroyRows(array, k1, k2);
                    Console.WriteLine("Отриманий масив після виконання блоку:");
                    OutputForJaggedArray(array);

                    break;
                //Matula=========================================
                case 'r':
                    array = Potaichuk.Block3(array);
                    break;
            }
        }
    }
}
