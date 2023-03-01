// В двумерном массиве n×k заменить четные элементы на противоположные

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

void PrintArray(int [,] array, string text)
    {
        Console.WriteLine("\n");
        Console.WriteLine(text);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (array[i,j] >= 0)
                    Console.Write($" {array[i,j]} \t");
                else
                    Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
        }
    }

void ChangeEvens(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i,j]%2 == 0) array[i,j] = array[i,j]*-1;
    }
}

int n = ReadInt("Введите число n: ");
int k = ReadInt("Введите число k: ");

int [,] numbers = new int[n,k];

FillArray(numbers);
PrintArray(numbers, "Оригинальный массив: ");
ChangeEvens(numbers);
PrintArray(numbers, "Новый массив: ");
