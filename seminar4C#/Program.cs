// Напишите программу, которая принимает на вход число 
// (А) и выдаёт сумму чисел от 1 до А.

// int SumFromTon(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum += i;  
//     }
// }

// int InputNum (string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.RedLine()!);
// }

// int num = InputNum("Введите целое число: ");
// int sum = SumFromTon(num);
// Console.WriteLine($"Сумма чисел от 1 до N равна {sum}.");


// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5




// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int DigitNum(int num)
// {
//     int index = 0;
//     while (num != 0)
//     {
//         num /= 10;
//         index++;
//     }
//     return index;
// }

// int num = InputNum("Введите целое число: ");
// int number = DigitNum(num);
// Console.WriteLine(number);

// Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int Factorial(int num)
// {
//     int sum = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         sum = sum * i;
//     }
//     return sum;  
// }

// int num = InputNum("Введите целое число: ");
// int fuct = Factorial(num);
// Console.WriteLine(fuct);


// Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] ArrayRand(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
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

// int len = InputNum("Введите длинну массива: ");
// int[] arr = ArrayRand(len);
// PrintArray(arr);



вывод количества чисел после запятой(округление)

double num = 0.12345;
Console.WriteLine($"{num:f2}");