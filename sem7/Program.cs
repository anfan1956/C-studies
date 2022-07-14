// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// *Задача 49: *Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.WriteLine("\nЗадача 48. Семинар");
Console.WriteLine("// матрица, где каждый элемент - сумма его индексов");
int m = 3, n = 4;
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write($"{i + j}\t");
    }
    Console.Write($"\n");
}

// -------------------------------------------------
Console.WriteLine("\nЗадача 49. Семинар");
Console.WriteLine("// матрица случайных чисел");
m = 5;
n = 5;
matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write($"{matrix[i, j]}\t");

    }
    Console.Write($"\n");
}
Console.Write($"\n");
Console.WriteLine("// таже матрица, элемент с обоими четными индексами - в квадрате");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] *= (i % 2 == 0 && j % 2 == 0) ? matrix[i, j] : 1;
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.Write($"\n");
}


// H  O  M  E  W  O  R  K  
// -----------------------------------------------
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("\nЗадача 47. Домашнее задание");
Console.WriteLine("// матрица случайных вещественных чисел");
int rowsCount = 3;
int columnsCount = 4;
int upperLimit = 10;
double[,] arrayDoubles = new double[rowsCount, columnsCount];
for (var i = 0; i < rowsCount; i++)
{
    for (var j = 0; j < columnsCount; j++)
    {
        arrayDoubles[i, j] = Math.Round(new Random().NextDouble() * (new Random().Next(0, 2) * 2 - 1)
            * upperLimit, 1);
        Console.Write($"{arrayDoubles[i, j]} \t");
    }
    Console.Write($"\n");
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("\nЗадача 50. Домашнее задание");
Console.WriteLine("// выводит элемент массива по введенным строке с индексами или сообщение 'такого элемента нет'");
rowsCount = new Random().Next(2, 10);
columnsCount = new Random().Next(2, 10);

matrix = new int[rowsCount, columnsCount];
for (var i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.Write($"\n");
}
Console.WriteLine("введите индекс строки и столбца элемента, через пробел;");
string positionString = Console.ReadLine();
int[] indeces = Array.ConvertAll(positionString.Split(" "), int.Parse);
int row = indeces[0];
int column = indeces[1];

// int row = positionString[0] - '0';
// int column = positionString[1] - '0';

string returnMessage = (row < rowsCount && column < columnsCount) ? Convert.ToString(matrix[row, column]) : "такого елемента нет";
Console.WriteLine($"{positionString} -> {returnMessage}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//чтобы было нескучно, создадим массив, где и число колонок и число строк больше 2

Console.WriteLine("\nЗадача 52. Домашнее задание");
Console.WriteLine("// вывести среднее арифметическое значение столбца матрицы");
rowsCount = new Random().Next(2, 10);
columnsCount = new Random().Next(2, 10);
double[] columnAverage = new double[columnsCount];

matrix = new int[rowsCount, columnsCount];
for (var i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        matrix[i, j] = new Random().Next(10);
        columnAverage[j] += matrix[i, j];
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.Write($"\n");
}

Console.WriteLine("среднее арифметическое:");
for (int j = 0; j < columnsCount; j++)
{
    Console.Write($"{Math.Round(columnAverage[j] / rowsCount, 1)} \t");
}

