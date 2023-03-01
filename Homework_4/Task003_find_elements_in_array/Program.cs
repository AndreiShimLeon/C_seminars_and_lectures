// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] CreateRandomArray (int length, int lower, int higher)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(lower, higher+1);
    return array;
} 

void PrintArray (int[] array)
{
    Console.Write("Array: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
} 

int[] FindSetOfNumbersInArray(int[] array, int lowest, int highest)
{
    int count = 0;
    foreach (int item in array)
    {
      if (item >= lowest && item <= highest) count++;
    }
    
    int[] lookForElements = new int[count];
    count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= lowest && array[i] <= highest) 
        {
        lookForElements[count] = array[i];
        count++;
        }
    }
    return lookForElements;
}

int[] numbers = CreateRandomArray(123,0,999);
Console.WriteLine("\nОригинальный массив: ");
PrintArray(numbers);

int[] neededNumbers = FindSetOfNumbersInArray(numbers, 10, 99); 
Console.WriteLine("\nМассив с двузначными числами: ");
PrintArray(neededNumbers);

Console.WriteLine($"Количество двузначных чисел: {neededNumbers.Length}");

