/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] SprialFill2DArray(int rows)
{
    int count = 1;
    int side = rows;
    int start = 0;
    int[,] matrix = new int[rows,rows];
    while (count < rows*rows)
    {
        
        for (int k = start; k < side - 1; k++)
        {
            matrix[start,k] = count;
            count++;
        }
        for (int k = start; k < side - 1; k++)
        {
            matrix[k,side - 1] = count;
            count++;
        }
        for (int k = side - 1; k > start; k--)
        {
            matrix[side - 1,k] = count;
            count++;
        }
        for (int k = side - 1; k > start; k--)
        {
            matrix[k,start] = count;
            count++;
        }
        side--;
        start++;
        if(rows%2 == 1 && count == rows*rows) matrix[start,side - 1] = count;
    }
    return matrix;
}
void Print2DArray(int[,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write($"   {matrix[i, j]} ");
            else if (matrix[i, j] < 100)
                Console.Write($"  {matrix[i, j]} ");
            else
                Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int side = ReadInt("Enter square matrix side size: ");
int[,] matrix = SprialFill2DArray(side);

Print2DArray(matrix, "Created matrix: ");
