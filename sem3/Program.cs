/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int NumDigits(int x)
{
    int num = 0;
    while (x > 0)
    {
        x /= 10; num++;
    }
    return num;
}

bool IsPalindrom(int a) // ------------------------------------------- it works for a number of any lenght
{
    bool pal = true;
    int l = NumDigits(a);
    int counter = l / 2;
    string num = Convert.ToString(a);
    for (int i = 0; i < counter; i++)
    {
        if (num[i] == num[l - 1 - i])
        {
            continue;
        }
        else
        {
            pal = false;
            break;
        }
    }
    return pal;
}

Console.WriteLine();
Console.WriteLine("Задача 19. Палиндром");
int[] arr = { 14212, 12821, 23432, 452154, 452151254};
foreach (int a in arr) {

string response = IsPalindrom(a) ? "да" : "нет";
Console.WriteLine($" {a} -> {response}");
}

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine();
Console.WriteLine("Задача 19. Длина вектора");

int Sqr (int x) {
    int l = x * x;
    return l;
}

int [, , ] points =  {{{3, 6, 8}, {2, 1, -7}}, {{7,-5, 0}, {1,-1,9}}};
int nvs = points.GetLength(0);
int nps =points.GetLength(1);
int ncs = points.GetLength(2);

// Console.WriteLine($"число точек:{nps}, число координат:{ncs}, число векторов: {nvs}" );
string [] vector = {"A (3,6,8); B (2,1,-7)","A (7,-5, 0); B (1,-1,9)"};
int Square;
for (int k = 0; k < nvs; k++) {
    Square = 0;
    for (int i = 0; i < ncs; i++) {
            Square += Sqr(points[k, 0, i] - points[k ,1, i]);
    }
    double l = Math.Round(Math.Sqrt(Convert.ToDouble( Square)), 2);
    Console.WriteLine($"вектор {k+1}:  {vector[k]}  ->  {l}");
}

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int Cube (int x) {
    int l = x * x * x;
    return l;
}

void listNumberCubes(int n) { 
    Console.Write($"{n} -> ");
    for (int i = 1; i < n ; i++) {
        Console.Write($"{Cube(i)}, ");
    }
    Console.Write($"{Cube(n)} ");
}

Console.WriteLine();
Console.WriteLine("Задача 23. Длина таблица кубов");
Console.WriteLine("Введите целое число больше 2:");
int num = Convert.ToInt32(Console.ReadLine());
listNumberCubes(num);

