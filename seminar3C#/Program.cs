



// int[] InputSomeNums()
// {
//     Console.Write("Введите количество чисел: ");
//     int size = int.Parse(Console.ReadLine()!);
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
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

// int[] myArray = InputSomeNums();
// PrintArray(myArray);









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

// int num = int.Parse(Console.ReadLine());
// int temp = num;

// int count = 0;
// while (temp != 0)
// {
//     temp = temp / 10; // num /= 10;
//     count++;
// }

// int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

// PrintArray(array);

// Console.Write($"\n{array[2]}");



// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой
//  находится эта точка.

// int InputNum (string message)
// {
//     Console.Write(Message);
//     return int.Parse(Console.ReadLine()!);
// }

// int Quard(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     else if (x < 0 && y > 0) return 2;
//     else if (x < 0 && y < 0) return 3;
//     else if (x > 0 && y < 0) return 4;
//     else return -1;   
// }

// int x = InputNum("Введите координату х: ");
// int y = InputNum("Введите координату y: ");

// int res = Quart(x, y);

// if (res == - 1) 
//     Console.WriteLine("Точка находится на пересечении четвертей");
// else
//     Console.WriteLine($"Четверть {res}");


// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон
//  возможных координат точек в этой четверти (x и y).


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int quarter = int.Parse(Console.ReadLine()!);
//     return quarter;
// }

// string GetQuarter(int quarter1)
// {
//     if (quarter1 == 1) return ("Координаты х и y должны быть больше 0");
//     else if (quarter1 == 2) return ("Координата х должна быть меньше 0, а координата y - больше 0");
//     else if (quarter1 == 3) return ("Координаты х и y должны быть меньше 0");
//     else if (quarter1 == 4) return ("Координата х должна быть больше 0, а координата y - меньше 0");
//     else return ("Введено неверное число");
// }

// int quarter = InputNum("Введите номер четверти (1-4);");

// string Num = GetQuarter(quarter);
// Console.WriteLine(Num);



// решение через войд/


// void Koord(string massage) 
// { 
//  System.Console.WriteLine(massage); 
//  int a = int.Parse(System.Console.ReadLine()!); 
//  if (a > 0 && a < 5) 
//  { 
//  if (a == 1) 
//  System.Console.WriteLine("x > 0, y > 0."); 
//  else if (a == 2) 
//  System.Console.WriteLine("x < 0, y > 0."); 
//  else if (a == 3) 
//  System.Console.WriteLine("x < 0, y < 0."); 
//  else if (a == 4) 
//  System.Console.WriteLine("x > 0, y < 0."); 
//  } 
//  else 
//  System.Console.WriteLine("Такой четверти нет."); 
// } 
// Koord("Введите номер четверти: ");



// Напишите программу, которая принимает на вход 
// координаты двух точек и находит
//  расстояние между ними в 2D пространстве.


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }


// int xA = InputNum("Введите x для A;");
// int yA = InputNum("Введите y для A;");
// int xB = InputNum("Введите x для B;");
// int yB = InputNum("Введите y для B;");

// double Root(int xA, int yA, int xB, int yB)
// {
//     double res1 = Math.Pow(xB - xA, 2);
//     double res2 = Math.Pow(yB - yA, 2);
//     double res = Math.Sqrt(res1 + res2);
//     return res;
// }


// double distance = Root(xA, yA, xB, yB);
// Console.WriteLine(Math.Round(distance, 2));


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел 
// от 1 до N.


int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;

}

int num = InputNum("Введите целое число.");
for (int i = 1; i <= num; i++)

{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < num)
    {
        Console.Write(", ");

    }
    else
    {
        Console.Write(".");
    }
}

