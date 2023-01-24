// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

int size = 123;
int minElement = EnterValue("Введите минимальное число в массиве: ");
int maxElement = EnterValue("Введите максимальное число в массиве: ");
int[] array = CreateArray(size, minElement, maxElement);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();

int minSegment = 10;
int maxSegment = 99;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= minSegment && array[i] <= maxSegment)
        count++;
}

Console.WriteLine($"Количество элементов массива из отрезка [{minSegment}, {maxSegment}] равно {count}");