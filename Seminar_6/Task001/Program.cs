// Показать двумерный массив размером m×n заполненный целыми числами

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void FillArray (int [,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(0,10);
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
    Console.WriteLine();
    }
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

int [,] numbers = new int[m,n];

FillArray(numbers);
PrintArray(numbers);