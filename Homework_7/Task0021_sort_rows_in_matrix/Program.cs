// Написать программу, упорядочивания по убыванию 
// элементы каждой строки двумерной массива.

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
            array[i,j] = random.Next(-99,100);
        }
    }
    return array;
}
void Print2DArray (int [,] array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] >= 0)
                {
                   if (array[i,j] < 10) Console.Write($"  {array[i,j]} ");
                   else Console.Write($" {array[i,j]} ");
                }
            else
                {
                   if (array[i,j] > -10) Console.Write($" {array[i,j]} ");
                   else Console.Write($"{array[i,j]} ");
                }
        }
        Console.WriteLine();
    } 
}
void SortMatrixRows (int[,] array)
{
    int max;
    int maxIndex = 0; 
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = 0;
        while (count < array.GetLength(1))
        {
            max = array[i,count];
            for (int j = count+1; j < array.GetLength(1); j++)
            {
                if (array[i,j] > max)
                {
                    maxIndex = j;
                    max = array[i,j];
                }
            }
            array[i,maxIndex] = array[i,count];
            array[i,count] = max;
            count++;
        }
    }
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] numbers = CreateAndFill2DArray(rows, columns);
Print2DArray(numbers, "Created matrix: ");

SortMatrixRows(numbers);
Print2DArray(numbers, "Sorted matrix: ");


