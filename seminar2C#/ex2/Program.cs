
int MaxDigit (int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else
        return second;
}

int RandomNum()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine($"Сгенерировалось число: {num}");
    return num;
}

int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.WriteLine($"Максимальная цифра в числе {rand} = {maxDigit}");




int RandomNum()
{
    int num = new Random().Next(10, 1000);
    Console.WriteLine($"Сгенерировалось число: {num}");
    return num;
}


123 -> 13
123 % 10 = 3 
123 / 100 = 1
10* 1 + 3 = 13

int DelSecondDigit(int num)
{
    int first = num / 100;
    int second = num % 10;
    int twoDigits = first *10 + second;
    return twoDigits;
}
int number = RandomNum();
int result = DelSecondDigit(number);
Console.WriteLine($"Получилось: {result}");





// Напишите программу, которая будет принимать на вход
//  два числа и выводить, является ли второе число кратным первому.
//   Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int Numbers(string message)
{
      Console.WriteLine(message);
      int numA = Convert.ToInt32(Console.ReadLine());
      return numA;
}

int number1 = Numbers("Введите первое число");
int number2 = Numbers("Введите первое число");

void Division(int num1, int num2)
{
    int two = num1 % num2;
    if (two == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Некратно, остаток" + two);
    }
} 
Division (number1, number2);

// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string Multiplicity(int number)
{
    string result = "no";
    if (number % 7 == 0 && number % 23 == 0)
    
    result = "Yes";
    
    return result;
}

int num = InputNum("Введите целое число");
string result = Multiplicity(num);
Console.WriteLine(result);


