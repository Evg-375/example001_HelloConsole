// Задача 39: Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[] CreateArray(int size)
// {
//     return new int[size];
// }


// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max+1);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i]+" ");
//     Console.WriteLine(" ");    
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum();
// int maxValue = InputNum();

// int[] myArray = CreateArray(size);
// FillArray



// // дописать 




// Задача 40: Напишите программу, которая принимает
//  на вход три числа и проверяет, может ли существовать
//   треугольник с сторонами такой длины.


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// bool Pifagor(int a, int b, int c)
// {
//     if(a + b < c && b + c < a && c + a < b) return true;
//     return false;
// }


// int num = InputNum("Введите первое число");
// int num1 = InputNum("Введите второе число");
// int num2 = InputNum("Введите третье число");

// bool check = Pifagor(num, num1,num2);
// Console.WriteLine(check);


// Задача 42: Напишите программу, которая будет
//  преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }



// int[] Division(int num)
// {
//     int temp = num;
//     int index = 0;
//     int res = num;
//     while (temp != 0)
//     {
//         temp /= 2;
//         index++;
//     }

//     int[] array = new int[index];

//     for (int i = 0; i < array.Length; i++)
//     {
//         res %= 2;
//         num /= 2;
//         array[i] = res;
//     }
//     return array;
// }


// void RevArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
//     Console.WriteLine();
// }


// int number = InputNum("Введите число");
// int[] myArray = Division(number);
// RevArray(myArray);
// PrintArray(myArray);


// решение валерии

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] Division(int num)
// {
//     int temp = num;
//     int index = 0;
//     int res = num;
//     while (temp != 0)
//     {
//         temp = temp / 2;
//         index++;
//     }
//     int[] array = new int[index];
//     for (int i = 0; i < array.Length; i++)
//     {
//         res = num % 2;
//         num = num / 2;
//         array[i] = res;
//     }
//     return array;
// }
// void RevArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
//     Console.WriteLine();
// }

// int number = InputNum("Введите число");
// int[] myArray = Division(number);
// PrintArray(myArray);
// RevArray(myArray);
// PrintArray(myArray);

// Решение османа 


// Console.Clear();
// System.Console.WriteLine("число: ");
// int num = int.Parse(Console.ReadLine());
// string count = "";

// while (num > 0)
// {
// 	count = num % 2 + count;
// 	num = num / 2;
// }
// System.Console.WriteLine(count);


// Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// void Fibonacci(int num)
// {
//     int first = 0;
//     int second = 1;
//     int res = 0;

//     if (num == 1) Console.WriteLine(first);
//     else 
//     Console.WriteLine(first + " ");

//     for (int i = 0; i < num - 1; i++)
//     {
//         res = second;
//         second += first;
//         first = res;
//         Console.WriteLine(" "+res);
//     }

// }

// int number = InputNum("Введите целое число: ");
// Fibonacci(number);


// Решение юлии


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// void Fibonacci(int num)
// {
//     if (num == 1)
//         Console.Write("0");
//     else
//         Console.Write("0 1");
//     int a =0;
//     int b =1;
//         for (int i = 2; i < num; i++)
//     {
//         int temp= b;
//         b=a+b;
//         a=temp;
//         Console.Write(" "+b);        
//     }
// }
// int num = InputNum("");
// Fibonacci(num);


// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

// int[] A = {3, 4, 5, 6};
// Console.WriteLine((String.Join)" ", A);
// int[] C = new int[A.Length];

// for (int i = 0; i < C.Length; i++)
// {
//     C[i] = A[i];
// }

// A[2] = 10;

// Console.WriteLine((String.Join)" ", A);
// Console.WriteLine((String.Join)" ", C);


// int[] A = {3, 4, 5, 6};
// Console.WriteLine(String.Join(" ", A));
// int[] C = new int[A.Length];

// for (int i = 0; i < C.Length; i++)
// {
//     C[i] = A[i];
// }

// Console.WriteLine(String.Join(" ", C));
// A[2] = 10;
// Console.WriteLine(String.Join(" ", A));
// Console.WriteLine(String.Join(" ", C));



/*
int[C] = A; // та же ссылка на массив А
// если менять А, то ищменится и С
*/