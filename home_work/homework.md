<!-- Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 -->

Console.WriteLine("Введите первое число: ");
int numA = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
int numВ = Console.ReadLine();

if ( numA > max ) max = numA;
if ( numВ > max ) max = numВ;

if ( numA < min ) min = numA;
if ( numВ < min ) min = numВ;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);

<!-- Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 -->

Console.Write("Введите первое число: ");
int numA = Console.ReadLine();

Console.Write("Введите второе число: ");
int numB = Console.ReadLine();

Console.Write("Введите третье число: ");
int numC = Console.ReadLine();

if ( numA > max ) max = numA;
if ( numВ > max ) max = numВ;
if ( numC > max ) max = numC;

Console.Write("max = ");
Console.WriteLine(max);

<!-- Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет -->

Console.Write("Введите целое число: ");
int numA = Console.ReadLine();

if ( numA % 2 == 0 )
{
    Console,WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}

<!-- Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 -->

Console.Write("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = 2;

if ( numA > 1 )
   {
      While(numB <= numA )
      {
        Console.Write(numB + " ");
        numB = numB + 2;
      }
   }