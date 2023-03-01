/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] CreateAndFill2DArray(int rows, int columns)
{
    int [,] array = new int [rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }
    return array;
}
void Print2DArray (int [,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] >= 0)
                Console.Write($" {matrix[i,j]} ");
            else
                Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    } 
}
int MinimumIndexInArray(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length ; i++)
    {
        if(array[i] < min) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}
int [] RowSums(int [,] matrix)
{
    int sum = 0;
    int [] rowsMins = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        rowsMins[i] = sum;
        sum = 0;
    }
    return rowsMins;
}
int MinimumRowSum(int [,] matrix)
{
    return MinimumIndexInArray(RowSums(matrix));
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] numbers = CreateAndFill2DArray(rows, columns);
Print2DArray(numbers, "Created matrix: ");
Console.WriteLine($"Row #{MinimumRowSum(numbers)} has minimum sum. ");