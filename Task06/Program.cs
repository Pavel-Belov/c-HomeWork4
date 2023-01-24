// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void MultiplyElements(int[] array)
{
    int mult = 0;

    for(int i = 0; i < array.Length / 2; i++)
    {
            int el1 = array[i];
            int el2 = array[array.Length - i - 1];
            mult = el1 * el2;
            Console.WriteLine($"Произведение пары {i} и {array.Length - i - 1} элементов массива равно: {el1} * {el2} = {mult}");    
    }
}

int size = EnterValue("Введите размер массива: ");
int min = EnterValue("Введите минимальное число в массиве: ");
int max = EnterValue("Введите максимальное число в массиве: ");

int[] array = CreateArray(size, min, max);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();

MultiplyElements(array);