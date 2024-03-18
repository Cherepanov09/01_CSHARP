// Задача 1. Задайте значения M и N. Напишите программу,которая выведет все натуральные
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void CountInteger(int m, int n)
{
    if (m == n)
    {
        Console.WriteLine(n);
        return;
    }

    CountInteger(m, n - 1);
    Console.WriteLine(n);
}

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    int temp = 0;
    temp = n;
    n = m;
    m = temp;
}

CountInteger(m, n);
