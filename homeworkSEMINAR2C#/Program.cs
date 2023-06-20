// // Задача 10: Напишите программу, которая принимает на вход
// //  трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int SecondNumber(int num)
// {
//     int num2 = num / 10;
//     int num3 = num2 % 10;
//     return num3;
// }

// int num = InputNum("Введите целое число");
// int result = SecondNumber(num);
// Console.WriteLine(result);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = Convert.ToInt32(Console.ReadLine()!);
//     return num;
// }

// bool ThreeNumb(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int Trim(int num)
// {
//     while (num > 999)
//     {
//          num = num / 10;;
//     }
//     return num % 10;
// }


// int num = InputNum("Введите целое число");
// if (ThreeNumb(num))
// {
//     Console.WriteLine(Trim(num));
// }




//  Задача 15: Напишите программу, которая принимает на вход цифру,
//   обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



// int Numbers(string message)
// {
//       Console.WriteLine(message);
//       int numA = Convert.ToInt32(Console.ReadLine());
//       return numA;
// }

// bool HappyDays(int days)
// {
//     if(days > 5 && days <8)
//     {
//         return true;
//     }
//     return false;
// }

// bool CheckWeekDay(int number)
// {
//     if (number >0 && number <=7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;
// }

// int weekday = Numbers("Введите число соответствующее дню недели");
// if(CheckWeekDay(weekday))
// {
//     if(HappyDays(weekday))
//     {
//         Console.WriteLine("Выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Рабочий день");
//     }
// }