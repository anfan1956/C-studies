/*  ---------------------------------------------------------------------------------------------------------------------
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// для начала пишем функцию, которая определит количество цифр в числе

int NumDigits(int x)
{
    int num = 0;
    while (x > 0)
    {
        x /= 10;
        num++;
    }
    return num;
}

// затем пишем функцию, которая принимает переменные x: число, n: n -я по счету цифра 
// и проверяет количество цифр, если меньше n - возвращает ошибку (-1), иначе - n-ю цифру
int NthDigit(int x, int n)
{
    int d = NumDigits(x);
    if (d >= n)
    {
        for (int i = 0; i < d - n; i++)
        {
            x /= 10;
        }
        d = x % 10;
    }
    else d = -1;
    return d;
}
int pl = 2;
int[] MyNums = { 456, 782, 918 };

Console.WriteLine();
Console.WriteLine("Задача 15.");

foreach (int item in MyNums)
{
    Console.WriteLine($"{item} ->  {NthDigit(item, pl)}");
}

/* --------------------------------------------------------------------------------------------------------------------
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine();
Console.WriteLine("Задача 15.");

MyNums = new[] { 645, 78, 32679 };
foreach (int item in MyNums)
{
    string digit = Convert.ToString(NthDigit(item, 3));
    if (digit == "-1") digit = "третьей цифры нет"; 
    Console.WriteLine($"{item} -> {digit}");
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine();
Console.WriteLine("Задача 15.");
Console.WriteLine("Введите номер дня недели");
int d = Convert.ToInt32( Console.ReadLine());
string response = "нет";
switch (d)
{
    case  6:
        response = "да";
        break;
    case  7:
        response = "да";
        break;
}
Console.WriteLine($"{d} -> {response}");