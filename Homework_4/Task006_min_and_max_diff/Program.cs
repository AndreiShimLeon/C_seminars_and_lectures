// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] CreateRandomArray (int length, int higher)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        array[i] = Math.Round(new Random().NextDouble()*higher, 2);
    return array;
} 

void PrintArray (double[] array, string text)
{
    Console.Write(text);
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
} 

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        max = (array[i] > max)? array[i] : max;
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        min = (array[i] < min)? array[i] : min;
    }
    return min;
}

// double[] numbers = {11.2, 14.1, 24.3, 7.8, 34.3, 32.1};
double[] numbers = CreateRandomArray(10,9);
PrintArray(numbers, "Оригинальный массив: ");

Console.WriteLine($"Разница между max = {FindMax(numbers)} и min = {FindMin(numbers)} равна {FindMax(numbers) - FindMin(numbers)}.");
