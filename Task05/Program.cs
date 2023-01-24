// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;    
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write(element + " ");
}

int EnterValue(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int size = EnterValue("Введите размер массива: ");
int min = EnterValue("Введите минимальное число в массиве: ");
int max = EnterValue("Введите максимальное число в массиве: ");

int[] array = CreateArray(size, min, max);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();

int sum = 0;

for(int i = 1; i < array.Length; i += 2)
{
        sum += array[i];
}

Console.WriteLine($"Сумма элементов массива с нечётными индексами равна {sum}");