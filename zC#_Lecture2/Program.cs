// // Функция Max перебирает 3 числа за раз и показывает большее из них.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
// // Добавляем массив из N чисел
int[] array = { 11, 547, 34, 76, 623, 72, 76, 98, 86 };

// // Запускаем ранее созданную функцию и перебираем все числа по индексу.
int result = Max(
    Max(array[0], array[1],array[2]),
    Max(array[3], array[4],array[5]),
    Max(array[6], array[7],array[8]));

Console.WriteLine(result);


Следующие метод находит индекс числа из массива и останавливает программу. 

int[] array = { 11, 54, 34, 76, 23, 72, 76, 98 };

// lenght обозначает велечину массива (применяя к этому индекс максимальный 7)
int n = array.Length;

// Тут вводим значение, чью позицию в массиве нужно найти.
int find = 72;

// Начинаем перебирать с самой первой позиции индекса (со значения 0).
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
       Console.WriteLine(index);
         break;
    }

    //index = index + 1;
    index++;
}
