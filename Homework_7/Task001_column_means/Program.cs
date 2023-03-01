// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов
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
void Print2DArray (int [,] array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] >= 0)
                Console.Write($" {array[i,j]} ");
            else
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}
void PrintArray(double [] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1)
            Console.Write($"{Math.Round(array[i], 2)})");
        else
            Console.Write($"{Math.Round(array[i], 2)}; ");
    }
}
double[] ColumnsMeans (int [,] array)
{
    double sum = 0;
    int count = 0;
    double[] means = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += Math.Pow(array[i,j],1);
            count++;
        }
        
        means[j] = sum/count;
        sum = 0;
        count = 0;
    }
    return means;
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] numbers = CreateAndFill2DArray(rows, columns);
Print2DArray(numbers, "Created matrix: ");
double [] columnMeans = ColumnsMeans(numbers);
Console.Write($"Means of matrix columns: ");
PrintArray(columnMeans);


