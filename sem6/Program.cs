// Seminar tasks.
// Для того, чтобы получить ряд Фибоначчи, создаем функцию int[] Fibonacci
int[] Fibonacci(int N)
{
    int[] fibArray = new int[N];
    fibArray[0] = 0;
    fibArray[1] = 1;
    for (int i = 0; i < N; i++)
    {
        fibArray[i] = i < 2 ? fibArray[i] : fibArray[i - 1] + fibArray[i - 2];
    }
    return fibArray;
}
int n = 10;
Console.WriteLine($"\nСеминар: fibonacci({n}): {String.Join(" ", Fibonacci(n))}");

// ------------------------------------------------------------------------
//Целое число, представленное десятиричном виде, представить в бинарном виде
// Число будет представлено в виде строки

String Binary(int n)
{
    string binary = "";
    while (n > 0)
    {
        binary = Convert.ToString(n % 2) + binary;
        n /= 2;
    }
    return binary;
}

n = 253;
Console.WriteLine($"\nСеминар: Бинарное представление числа {n}: {Binary(n)}");

// H O M E W O R K!
// ------------------------------------------------------------------------------------
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// first var create void function - use individual number input
Console.WriteLine("\n" + "Задача 41");
void CountNegative(int M)
{
    int[] numbers = new int[M];
    int countNegative = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите число № {i + 1} из {M}:");

        numbers[i] = Convert.ToInt32(Console.ReadLine());
        countNegative += numbers[i] < 0 ? 1 : 0;
    }
    Console.WriteLine($"{String.Join(", ", numbers)} - > {countNegative}");
}
int M = 3;
CountNegative(M);

// second var  - without creating a function, using Array.ConvertAll
int countNegative = 0;
Console.WriteLine("Enter set of integer numbers, separated by space, please:");
string arrayString = Console.ReadLine();
Console.WriteLine(arrayString);
int[] numbers = Array.ConvertAll(arrayString.Trim().Split(" "), int.Parse);
for (int i = 0; i < numbers.Length; i++)
{
    countNegative += numbers[i] < 0 ? 1 : 0;
}
Console.WriteLine($"{String.Join(", ", numbers)} - > {countNegative}");


// -------------------------------------
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Точка пересечения двух прямых - это решение системы линейных уравнений, 
// задаюцих эти прямые
// Для решения воспользуемся методом Крамера: x = delta_x/delta; y = delta_y/delta, где
// delta - matrix determinant (определитель матрицы), delta_x и delta_y - variables determinats (определители переменных)
//Для этого создадим функцию LinearEquationSolution;
//В качестве аргумента используем двухменную матрицу коэффициентов {{k1, b1}, {k2, b2}}
//для упрощения приведем уравнения к каноническому виду
// y - k1 * x = b1; 
// y - k2 * x = b2;

double[] LinearEquationSolution(int k1, int k2, int b1, int b2)
{
    int delta = k1 - k2;
    if (delta == 0) { throw new ArgumentException("у прямых не определена точка пересечения"); }
    int delta_x = -b1 * k2 + k1 * b2;
    int delta_y = b2 - b1;
    double x = Math.Round((double)delta_x / (double)delta, 1);
    double y = Math.Round((double)delta_y / (double)delta, 1);
    double[] solution = { x, y };
    return solution;
}

Console.WriteLine("\n" + "Задача 43");
Console.WriteLine("enter k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter b2");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] solution = LinearEquationSolution(k1, k2, b1, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -->  ({String.Join(", ", solution)})");



