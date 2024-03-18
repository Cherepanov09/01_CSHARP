// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackerman(int n, int m)
{

    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
            return Ackerman(n - 1, 1);
        }
        else
        {
            return Ackerman(n - 1, Ackerman(n, m - 1));
        }
    }
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(m, n);
Console.WriteLine(result);


// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))