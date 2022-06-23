/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int a = 5, b = 7, max_num, min_num;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("max number: " + max_num + ", min number: " + min_num);


a = 2; b = 10;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("max number: " + max_num + ", min number: " + min_num);

a = -9; b = -3;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("max number: " + max_num + ", min number: " + min_num);
