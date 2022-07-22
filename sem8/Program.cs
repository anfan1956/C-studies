// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
using System.Collections;
Console.WriteLine("Задача 54. Упорядочить по убыванию");
int rows = 3;
int columns = 4;

int[,] array = new int[rows, columns];

Console.WriteLine(" массив до сортировки:");
for (var i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

int[] tempArray = new int[columns];
for (var i = 0; i < rows; i++)
{
    tempArray = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        tempArray[j] = array[i, j];
    }

    Array.Sort(tempArray);

    for (int j = 0; j < columns; j++)
    {
        array[i, j] = tempArray[j];
    }
}
Console.WriteLine(" массив после сортировки:");

for (var i = 0; i < rows; i++)
{
    for (var j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("\n\n");
Console.WriteLine("Задача 56. найти строку с минимальной суммой");
int min = 0;
int rowMinSum = 1;
for (var i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(100);
        sum += array[i, j];
        Console.Write(array[i, j] + "\t");
    }
    if (i == 0)
    {
        min = sum;
    }
    else
    {
        if (sum < min)
        {
            min = sum;
            rowMinSum = i;
        }
    }

    Console.WriteLine();
}
Console.WriteLine($"строка {rowMinSum} (индекс строки) c минимальной сумой {min}");

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int numbersRange = 10;
rows = new Random().Next(2, 5);
columns = new Random().Next(2, 5);

int[,] array1 = new int[rows, columns];
int[,] array2 = new int[rows, columns];
int[,] arrayProduct = new int[rows, columns];
for (var i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array1[i, j] = new Random().Next(numbersRange);
        array2[i, j] = new Random().Next(numbersRange);
        arrayProduct[i, j] = array1[i, j] * array2[i, j];
    }
}
Console.WriteLine("\n\nЗадача 58. Произведение матриц");
void PrintArray(int rows, int columns, int[,] matrix)
{
    for (var i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Матрица1");
PrintArray(rows, columns, array1);
Console.WriteLine("Матрица2");
PrintArray(rows, columns, array2);
Console.WriteLine("Произведение матриц");
PrintArray(rows, columns, arrayProduct);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

/// поскольку есть ограничение на то, что числа двузначные и неповторяющиеся и
/// предполая, что массив  - куб ( в отличие от параллелепипеда) максимальный размер  - 4
/// т.к. 4 ^ 3 = 64, а 5 ^ 3 = 125. для усложнения зададим размер 4
/// методы HasSet использовать не буду с целью дополнительной тренировки работы с матрицамм

Console.WriteLine("\n\nЗадача 60. Трехмерный массив");

int len = 4;
int[,,] array3D = new int[len, len, len];
List<int> checker = new List<int>();
int number = 0;

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
    {
        for (int k = 0; k < len; k++)
        {
            bool contains = true;
            while (contains)
            {
                number = new Random().Next(10, 100);
                contains = checker.Contains(number);
            }
            array3D[i, j, k] = number;
            checker.Add(number);
            Console.Write($"{number}({i},{j},{k})   ");
        }
        Console.Write("\t");

    }
    Console.Write("\n");
}

/// задача 62. 
/// Больше возни. Если будет время - сделаю