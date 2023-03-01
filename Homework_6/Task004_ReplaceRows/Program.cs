// Написать программу, которая обменивает элементы первой строки и последней строки
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
void FillArray (int [,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = rnd.Next(0,10);
        }
    }

void ReplaceRows(int [,] array)
{
    int[] firstRow = new int[array.GetLength(1)];
    int[] lastRow = new int[array.GetLength(1)];    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        firstRow[i] = array[0,i];
        lastRow[i] = array[array.GetLength(0)-1,i];
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0,i] = lastRow[i];
        array[array.GetLength(0)-1,i] = firstRow[i];
    }
}
int m = ReadInt("Enter a number of rows: ");
int n = ReadInt("Enter a number of columns: ");

int[,]numbers = new int[m,n];
FillArray(numbers);
PrintArray(numbers, "Original matrix: ");
ReplaceRows(numbers);
PrintArray(numbers, "New matrix: ");
