// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

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

int[] array = CreateArray(8, 0, 1);
Console.WriteLine("Массив случайных чисел от 0 до 1: ");
PrintArray(array);