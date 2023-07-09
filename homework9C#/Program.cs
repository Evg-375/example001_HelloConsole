// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1.
//   Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// int InputNum (string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     PrintNumbers(++start, end);
//     Console.Write(start + " ");

// }

// int num = InputNum("Введите целое число: ");
// PrintNumbers(0, num -1);





// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// int FindSum(int M, int N)
// {
//     if (M > N)
//     {
//         Console.Write("Значение M должно быть меньше или равно значению N");
//         return 0;
//     }
//     else if (M == N)
//     {
//         return M;
//     }
//     else
//     {
//         return M + FindSum(M + 1, N);
//     }
// }

// int M = InputNum("Введите значение M: ");
// int N = InputNum("Введите значение N: ");
// int sum = FindSum(M, N);
// Console.WriteLine(sum);





// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }


// int Ackermann(int M, int N)
// {
//     if (M == 0)
//     {
//         return N + 1;
//     }
//     else if (M > 0 && N == 0)
//     {
//         return Ackermann(M - 1, 1);
//     }
//     else if (M > 0 && N > 0)
//     {
//         return Ackermann(M - 1, Ackermann(M, N - 1));
//     }
//     else
//     {
//         Console.WriteLine("Значения m и n должны быть неотрицательными");
//         return 0;
//     }
// }


// int M = InputNum("Введите значение M: ");
// int N = InputNum("Введите значение N: ");
// int result = Ackermann(M, N);
// Console.WriteLine(result);