// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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
int min = 100;
int max = 999;

int[] array = CreateArray(size, min, max);
Console.WriteLine("Массив случайных трёхзначных чисел: ");
PrintArray(array);
Console.WriteLine();

int evenNumber = 0;
int oddNumber = 0;

for(int i =0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        evenNumber++;
    else
        oddNumber++; 
}

Console.WriteLine($"Количество чётных чисел: {evenNumber}");
Console.WriteLine($"Количество нечётных чисел: {oddNumber}");