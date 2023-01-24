// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] CreateArray(int size, double min, double max)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (random.NextDouble() * (max - min)) + min;
    }

    return array;    
}

void PrintArray(double[] array)
{
    foreach (double element in array)
        Console.Write(element + " ");
}

double EnterValue(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double[] SearchMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
            if (array[i] < min)
                min = array[i];
            else if (array[i] > max)
                max = array[i];
    }

    double[] minMaxArr = new double[]{min, max};
    return minMaxArr;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
double min = EnterValue("Введите минимальное число в массиве: ");
double max = EnterValue("Введите максимальное число в массиве: ");

double[] array = CreateArray(size, min, max);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();

double[] minMaxArray = SearchMinMax(array);
double minEl = minMaxArray[0];
double maxEl = minMaxArray[1];
double difference = maxEl - minEl;

Console.WriteLine($"Минимальный элемент массива равен: {minEl}");
Console.WriteLine($"Максимальный элемент массива равен: {maxEl}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {maxEl} - {minEl} = {difference}");