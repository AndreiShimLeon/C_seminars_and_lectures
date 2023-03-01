// Показать числа Фибоначчи меньше N
// F0 = 1, F1 = 1, Fi = Fi-1 + Fi-2

int ReadInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int[] FibonacciNumbers(int number)
{
    int[] numbers = new int[number+1];
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i <= number; i++)
    {
        numbers[i] = numbers[i-1] + numbers[i-2];
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($" | {array[i]} | ");
}

void PrintFibonacciNumbers(int[] array, int number)
{
    for (int i = 0; array[i] < number; i++)
    Console.Write($" | {array[i]} | ");
}
int number = ReadInt("Введите число N: ");


PrintFibonacciNumbers(FibonacciNumbers(number), number);