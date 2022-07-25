// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine("\nЗадача 64.");
string PrintRange(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return PrintRange(m, n - 1) + ", " + Convert.ToString(n);
}
int M = 1, N = 5;
Console.WriteLine($"M = {M}, N = {N} ->  \"\"{PrintRange(M, N)}\"\"");
M = 4;
N = 8;
Console.WriteLine($"M = {M}, N = {N} ->  \"\"{PrintRange(M, N)}\"\"");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ArithmeticProgressionSum(int m, int n)
{
    if (m == n) return n;
    return ArithmeticProgressionSum(m, n - 1) + n;
}
Console.WriteLine("\nЗадача 66.");
M = 1;
N = 15;
Console.WriteLine($"M = {M}, N = {N} ->  {ArithmeticProgressionSum(M, N)}");
M = 4;
N = 8;
Console.WriteLine($"M = {M}, N = {N} ->  {ArithmeticProgressionSum(M, N)}");


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.WriteLine("\nЗадача 64.");
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
int m = 2, n = 3;
Console.WriteLine($"m = {m}, n = {n} -> Ackermann(m, n) = {Ackermann(m, n)}");
m = 3; n = 2;
Console.WriteLine($"m = {m}, n = {n} -> Ackermann(m, n) = {Ackermann(m, n)}");