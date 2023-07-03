
// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// double[,] Create2DArray(int rows, int cols)
// {
//     return new double[rows, cols];
// }


// void Fill2DArray(double[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             // array[i, j] = rnd.NextDouble() * 100;
//             array[i, j] = Math.Round((rnd.NextDouble() - 0.5) * 20, 2);
//         }
//     }
// }


// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]:F3}\t");
//         Console.WriteLine();
//     }
// }


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");

// double[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray);
// Print2DArray(myArray);
// Console.WriteLine();





// Задача 50. Напишите программу, которая на вход
//  принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же
//   указание, что такого элемента нет.



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// double[,] Create2DArray(int rows, int cols)
// {
//     return new double[rows, cols];
// }


// void Fill2DArray(double[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             // array[i, j] = rnd.NextDouble() * 100;
//             array[i, j] = Math.Round((rnd.NextDouble() - 0.5) * 20, 2);
//         }
//     }
// }


// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]:F3}\t");
//         Console.WriteLine();
//     }
// }


// double FoundPosition(double[,] array, int rows, int cols)
// {
//     if (rows >= 0 
//     || rows < array.GetLength(0) 
//     || cols >= 0 
//     || cols < array.GetLength(1))
//     {
//         return array[rows, cols];
//     }
//     else
//     {
//         return 0;
//     }
// }


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");

// double[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray);
// Print2DArray(myArray);
// Console.WriteLine();

// int ro = InputNum("Введите номер строки: ");
// int col = InputNum("Введите номер столбца: ");

// double element = FoundPosition(myArray, ro, col);


// void EL(double el)
// {
//     if (el == 0)
//     {
//         Console.WriteLine("Элемент не найден");
//     }
//     else
//     {
//         Console.WriteLine("Значение элемента: " + element);
//     }
// }


// EL(element);





// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.



// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }


// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(min, max + 1);
//         }
//     }
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }


// void Sum(int[,] array)
// {

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double res = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             res += array[i, j];
//         }
//     Console.Write($"{res / array.GetLength(0):F2};\t");
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// Sum(myArray);



