// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.



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


// void ChangeRows(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
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


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeRows(myArray);
// Print2DArray(myArray);




// Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы.
//  В случае, если это невозможно,
//   программа должна вывести сообщение для пользователя.




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


// void ChangeRowsColums(int[,] array)
// {
//     if (array.GetLength(0)!= array.GetLength(1))
//         Console.WriteLine("Не возможно изменить: ");
//     else for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 (array[j, i], array[i, j]) = (array[i, j], array[j, i]);
//             }
//         }
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
// ChangeRowsColums(myArray);
// Print2DArray(myArray);




// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.



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


// int[] Dict(int[,] array, int min, int max)

// {
//     int[] result = new int[max - min +1];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int index = array[i, j] - min;
//             result[index] ++;
//         }
//     }
//     return result;
// }



// void Result(int[] dict, int min)
// {
//     for (int i = 0; i < dict.Length; i++)
//     {
//         Console.WriteLine($"Число {i + min} встречается {dict[i]} раз(а)");
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


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] dictionary = Dict(myArray, minValue, maxValue);
// Result(dictionary, minValue);




// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.


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


// int[] PosMin(int[,] array)
// {
//     int min = array[0, 0];
//     int[] arrayiminjmin = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 arrayiminjmin[0] = i;
//                 arrayiminjmin[1] = j;
//             }
//         }
//     }
//     return arrayiminjmin;
// }


// int[,] NewCreate2DArray(int rows, int cols)
// {
//     return new int[rows - 1, cols - 1];
// }


// void FillNew2DArray(int[,] array2d, int[,] arraynew2d, int[] array)
// {
//     int row = 0;
//     int col = 0;
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         if (i == array[0]) continue;
//             for (int j = 0; j < array2d.GetLength(1); j++)
//             {
//                 if (j == array[1]) continue;
//                 arraynew2d[row, col] = array2d[i, j];
//                 col++;
//             }
//             col = 0;
//             row++;

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


// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] my2dArray = Create2DArray(rows, columns);
// Fill2DArray(my2dArray, minValue, maxValue);
// Print2DArray(my2dArray);
// Console.WriteLine();

// int[] myArray = PosMin(my2dArray);
// int[,] arraynew2d = NewCreate2DArray(rows, columns);
// FillNew2DArray(my2dArray, arraynew2d, myArray);
// Print2DArray(arraynew2d);





