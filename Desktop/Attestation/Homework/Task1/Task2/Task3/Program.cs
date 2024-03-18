// Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию,
// не использовать циклы.

int[] FillArrayRandomly(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void BackArrayPrint(int[] arr, int index = 0)
{
    if (index == arr.Length)
    {
        return;
    }
    BackArrayPrint(arr, index + 1);
    Console.Write($"{arr[index]} ");
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте массив из целых чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandomly(n);
PrintArray(array);
BackArrayPrint(array);
