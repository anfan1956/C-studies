
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine();
Console.WriteLine("Задача 37");

void ProductPairs(int[] array)
{
    int size = array.Length;
    bool isArrayLengthOdd = size % 2 == 0 ? false : true;
    int cycleSize = size / 2;
    int newArrayLength = cycleSize + Convert.ToInt32(isArrayLengthOdd);
    int[] newArray = new int[newArrayLength];

    for (var i = 0; i < cycleSize; i++)
    {
        newArray[i] = array[i] * array[size - i - 1];
    }
    if (isArrayLengthOdd)
    {
        newArray[cycleSize] = array[cycleSize];
    }
    Console.WriteLine($"[{String.Join(", ", array)}] -> {String.Join(" ", newArray)}");
}

int[] array = { 1, 2, 3, 4, 5 };
ProductPairs(array);
array = new int[] { 6, 7, 3, 6 };
ProductPairs(array);

// Внимание, внимание! *Начиная с этого дз при оценке учитывается оформление и названия переменных. Будьте внимательны)
// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine();
Console.WriteLine("Задача 34");

int size = 8;
array = new int[size];
int countEvenNumbers = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    countEvenNumbers += (array[i] % 2 == 0 ? 1 : 0);
}
Console.WriteLine($"[{String.Join(", ", array)}] -> {countEvenNumbers}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Я трактую нечетные позиции, как позиции с нечетным индексом
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Задача 36");
size = 7;
array = new int[size];
int sumOddIndeces = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    sumOddIndeces += (i % 2 == 0 ? 0 : array[i]);
}
Console.WriteLine($"[{String.Join(", ", array)}] -> {sumOddIndeces}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine();
Console.WriteLine("Задача 38");
int upperLimit = 100;
double min = 100;
double max = 0;

size = new Random().Next(3, 10);
double[] arrayRealNumbers = new double[size];

for (var i = 0; i < size; i++)
{
    arrayRealNumbers[i] = new Random().NextDouble() * upperLimit;
    min = arrayRealNumbers[i] < min ? arrayRealNumbers[i] : min;
    max = arrayRealNumbers[i] > max ? arrayRealNumbers[i] : max;
}
Console.WriteLine($"[{String.Join(", ", arrayRealNumbers)}] -> {max - min}");
Console.WriteLine();
