/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("");

int a = 5, b = 7, max_num, min_num, c;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("task 1, max number: " + max_num + ", min number: " + min_num);


a = 2; b = 10;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("task 1, max number: " + max_num + ", min number: " + min_num);

a = -9; b = -3;
if (a > b) {
   max_num = a; min_num = b;
} else
{
    max_num = b; min_num = a;
};
Console.WriteLine("task 1, max number: " + max_num + ", min number: " + min_num);

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*
*/

Console.WriteLine("");
a =2; b =3; c = 7;
max_num = a;
if (b > max_num) max_num = b;
if (c > max_num) max_num = c;
Console.WriteLine("task 4, max number: " + max_num );

a =45; b =5; c = 78;
max_num = a;
if (b > max_num) max_num = b;
if (c > max_num) max_num = c;
Console.WriteLine("task 4, max number: " + max_num );a =45; b =5; c = 78;

a =22; b =3; c = 9;
max_num = a;
if (b > max_num) max_num = b;
if (c > max_num) max_num = c;
Console.WriteLine("task 4, max number: " + max_num );