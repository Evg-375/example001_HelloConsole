// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.


double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}