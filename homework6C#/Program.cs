// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// int[] InputSomeNums()
// {
//     Console.Write("Введите количество чисел: ");
//     int size = int.Parse(Console.ReadLine()!);
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i + 1}-е число: ");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//         else
//             Console.Write(".");
//     }
// }


// int Check(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] > 0)

//             sum++;
//     }
//     return sum;
// }


// int[] myArray = InputSomeNums();
// PrintArray(myArray);
// int res = Check(myArray);
// Console.WriteLine();
// Console.WriteLine($"Введено {res} чисел(ла) болше нуля: ");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double InputNum(string message)
// {
//     Console.Write(message);
//     return double.Parse(Console.ReadLine()!);
// }

// void Main()
// {

//     double b1 = InputNum("Введите константу первой линии: ");
//     double b2 = InputNum("Введите константу второй линии: ");
//     double k1 = InputNum("Введите коэфициент первой линии: ");
//     double k2 = InputNum("Введите коэфициент второй линии: ");

//     if (k1 == k2)
//     {
//         Console.WriteLine("Прямые паралельны, точек пересечения нет");
//     }
//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = (k1 * (b2 - b1) / (k1 - k2) + b1);
//         Console.WriteLine($"Точка пересечения: x={x} y={y}");
//     }

// }

// Main();