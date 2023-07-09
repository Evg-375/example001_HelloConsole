// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
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


// static void SortRowDescending(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++) 
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++) 
//             {
//                 for (int k = j + 1; k < array.GetLength(1); k++) 
//                 {
//                     if (array[i, k] > array[i, j]) 
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }
//     }



// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
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

// SortRowDescending(myArray);
// Print2DArray(myArray);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
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


// int FindMinSumRowIndex(int[,] array)
// {
//     int minSumRowIndex = -1;
//     int minSumRowSum = int.MaxValue;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rowSum += array[i, j];
//         }
//         if (rowSum < minSumRowSum)
//         {
//             minSumRowIndex = i;
//             minSumRowSum = rowSum;
//         }
//     }

//     return minSumRowIndex;
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


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();

// int BEST = FindMinSumRowIndex(myArray);
// Console.WriteLine($"Строка с наименьшей суммой элементов: {BEST}");





// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
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


// int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
// {
//     int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)] ;
//     for (int i = 0; i < matrix1.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(0); j++)
//         {
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 result[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return result;
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


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();

// int[,] myArray2 = Create2DArray(rows, columns);
// Fill2DArray(myArray2, minValue, maxValue);
// Print2DArray(myArray2);
// Console.WriteLine();

// int[,] FinalArray = MultiplyMatrices(myArray, myArray2);
// Print2DArray(FinalArray);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//   добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// int[,,] Create3DArray(int x, int y, int z)
// {
//     return new int[x, y, z];
// }


// void Fill3DArray(int[,,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
// }


// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($"Слой {i}:");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }



// int x = InputNum("Введите размерность по x: ");
// int y = InputNum("Введите размерность по y: ");
// int z = InputNum("Введите размерность по z: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,,] myArray = Create3DArray(x, y, z);
// Fill3DArray(myArray, minValue, maxValue);
// Print3DArray(myArray);
// Console.WriteLine();





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



