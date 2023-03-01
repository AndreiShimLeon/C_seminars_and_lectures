// Задать двумерный массив следующим правилом: Aₘₙ = m+n
int ReadInt(string text)
    {
        Console.WriteLine(text);
        return int.Parse(Console.ReadLine()!);
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
void FillWithIndexSum(int [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = i+j;
        }
    }
int m = ReadInt("Enter a number of rows: ");
int n = ReadInt("Enter a number of columns: ");

int[,]numbers = new int[m,n];

FillWithIndexSum(numbers);
PrintArray(numbers, "Array: ");