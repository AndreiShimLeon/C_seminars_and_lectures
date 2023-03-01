// Программа сортирует весь двумерный массив

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
void Sort2DArray (int[,] array)
{
    int [] maxIndex = new int[] {0, 0}; 
    int max;
    int countRows = 0;
    int countInRow = 0;
    while (countRows < array.GetLength(0))
    {   
        max = array[countRows,countInRow];
        for (int i = countRows; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == countRows && j < countInRow) continue;
                else
                {
                    if(max <= array[i,j])
                    {
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                        max = array[i,j];
                    }
                }
            }
        }
        array[maxIndex[0],maxIndex[1]] = array[countRows,countInRow];
        array[countRows,countInRow] = max;

        countInRow++;
        if (countInRow == array.GetLength(1))
           {
            countInRow = 0;
            countRows++;
           }
    }
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] numbers = CreateAndFill2DArray(rows, columns);
Print2DArray(numbers, "Created matrix: ");

Sort2DArray(numbers);
Print2DArray(numbers, "Sorted matrix: ");

