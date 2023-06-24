//     Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//      Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[] CreateArray(int size)
// {
//     return new int[size];
// }


// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(100, 1000);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i]+" ");
//     Console.WriteLine(" ");    
// }


// int EvenNumber(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//             sum += 1;
//     return sum;
// }


// int size = InputNum("Введите размер массива: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray);
// PrintArray(myArray);

// int pos = EvenNumber(myArray);
// Console.WriteLine($"В массиве {pos} чётных чисел");



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[] CreateArray(int size)
// {
//     return new int[size];
// }


// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(-10, 11);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine(" ");
// }


// int OddNumber(int[] array)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         sum += array[i];
//         i += 2;
//     }
//     return sum;
// }


// int size = InputNum("Введите размер массива: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray);
// PrintArray(myArray);

// int pos = OddNumber(myArray);
// Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {pos}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// int size = InputNum("Введите количество элементов массива: ");
// double[] array = new double[size];


// void Create(int size)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.NextDouble() * 100;
//         Console.Write($"{array[i]:F3}  ");
//     }
//     Console.WriteLine();
// }


// double Result(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (max < array[i])
//             max = array[i];
//         if (min > array[i])
//             min = array[i];
//         i++;
//     }
//     return max - min;

// }


// Create(size);

// double qwe = Result(array);
// Console.Write($"Разница между максимальным и минимальным элементов массива {qwe:F3} ");