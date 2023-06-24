// // Задача 25: Напишите цикл, который принимает на вход два числа 
// // (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16



// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int InputNumDegree (string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int Exponentiation (int num, int num2)
// {
//     int res = 1;
//     for(int i = 1; i <= num2; i++)
//     res = res * num;
//     return res;  
// }


// int num = InputNum("Введите возводимое число: ");
// int num2 = InputNumDegree("Введите цифру степени: ");
// int res = Exponentiation(num, num2);
// Console.WriteLine(res);



//  Задача 27: Напишите программу, которая принимает на вход
//  число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int SumRes(int num)
// {
//     int counter = Convert.ToString(num).Length;
//     int sum = 0;
//     int residue = 0;
//         for(int i = 0; i < counter; i++)
//         {
//             residue = num - num % 10;
//             sum = sum + (num - residue);
//             num /= 10;
//         }
//     return sum;  
// }

// int num = InputNum("Введите число: ");
// int res = SumRes(num);
// Console.WriteLine(res);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] ArrayRand()
// {
//     int size = ;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
// }

// int[] arr = ArrayRand();
// PrintArray(arr);