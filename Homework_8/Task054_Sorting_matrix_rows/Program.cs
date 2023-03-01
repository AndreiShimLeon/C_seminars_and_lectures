/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
void SortingRowsInMatrix(int [,] matrix)
{
    int max;
    int maxIndex;
    int countInRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            max = matrix[i,k];
            maxIndex = k;
            for (int j = countInRow; j < matrix.GetLength(1); j++)
            {
                if(matrix[i,j] > max)
                {
                    max = matrix[i,j];
                    maxIndex = j; 
                }
            }
            matrix[i, maxIndex] = matrix[i, k];
            matrix[i, k] = max;
            countInRow++;
        }
        countInRow = 0;
    }
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] numbers = CreateAndFill2DArray(rows, columns);
Print2DArray(numbers, "Created matrix: ");
SortingRowsInMatrix(numbers);
Print2DArray(numbers, "New matrix: ");