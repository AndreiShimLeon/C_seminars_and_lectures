// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int[] CreateRandomArray (int length, int lower, int higher)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(lower, higher+1);
    return array;
} 

void PrintArray (int[] array)
{
    Console.Write("\nArray: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
} 

int EvenNumbersSum(int[] array)
{
    int sum = 0;
    foreach (int number in array)
    {
        if (number%2 == 0) sum+=number;
    }
    return sum;
}
int OddNumbersSum(int[] array)
{
    int sum = 0;
    foreach (int number in array)
    {
        if (number%2 == 1) sum+=number;
    }
    return sum;
}

int[] numbers = CreateRandomArray(10,100,999);
PrintArray(numbers);
Console.WriteLine($"Sum of even elements is: {EvenNumbersSum(numbers)}");
Console.WriteLine($"Sum of odd elements is: {OddNumbersSum(numbers)}");

