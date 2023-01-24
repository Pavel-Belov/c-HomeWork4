// Определить, присутствует ли в заданном массиве, некоторое число
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

int SearchNumberInArray(int[] array, int number)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            count++;
    }

    return count;
}

int size = EnterValue("Введите размер массива: ");
int min = EnterValue("Введите минимальное число в массиве: ");
int max = EnterValue("Введите максимальное число в массиве: ");

int[] array = CreateArray(size, min, max);
Console.WriteLine("Массив случайных чисел: ");
PrintArray(array);
Console.WriteLine();

int number = EnterValue("Введите число: ");
int count = SearchNumberInArray(array, number);

if (count > 0)
{
    Console.WriteLine($"В заданном массиве число присутсвует {count} раз(а)");

}
else
{
    Console.WriteLine("Данного числа в заданном массиве нет");
}