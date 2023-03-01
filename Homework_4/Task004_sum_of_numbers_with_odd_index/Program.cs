// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SumOfNumbersWithEvenOrOddPosition(int[] array, bool even) // (массив, позиция четная или нечётная)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
      if (even)
      {
        if ((index+1)%2 == 0) sum+=array[index];
      } 
      else
      {
        if ((index+1)%2 == 1) sum+=array[index];
      } 
    }

    return sum;
}

int[] numbers = CreateRandomArray(10,1,9);
PrintArray(numbers);

Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетной позиции: {SumOfNumbersWithEvenOrOddPosition(numbers, false)}");

