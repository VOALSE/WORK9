// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int GetSumNumber(int m, int n)
{
    if (m == n) return sum = sum + m;
    if (m != n && m <= n)
    {
        sum = n + GetSumNumber(m, n - 1);
    }
    else if (m != n && m >= n)
    {
        sum = n + GetSumNumber(m, n + 1);
    }
    return sum;
}

int result = GetSumNumber(numberFirst, numberSecond);
Console.WriteLine(result);