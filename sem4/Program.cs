// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int NumToPower(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}


// Задача 25:---------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Задача 25");
Console.WriteLine("введите основание степени");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите показатель степени");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}, {b} -> {NumToPower(a, b)}");

// Задача 27---------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Задача 27");
Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = x; i > 0; i /= 10)
{ sum += i % 10; }
Console.WriteLine($"{x} -> {sum}");


// Задача 29:---------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Задача 29");
string ArrayStr = "1, 34, 4, 54, 5";
Console.Write($"{ArrayStr} - > [");
int len = ArrayStr.Length;
var nums = ArrayStr.Split(", ");

// first method using Split
int nums_len = nums.Length;
Console.Write($"{nums[0]}");
for (int i = 1; i < nums_len; i++)
{
    Console.Write($", {nums[i]}");
}
Console.WriteLine("]  # first method using Split ");

// second method using Random
int len2 = 8;
int[] nums2 = new int[len2];
for (int i = 0; i < len2; i++)
{
    nums2[i] = new Random().Next(100);
}
Console.Write($"{string.Join(", ", nums2)} -> [");
Console.Write(nums2[0]);
for (int i = 1; i < len2; i++)
{
    Console.Write($", {nums2[i]}");
}

Console.Write("]  # second method using Random ");



