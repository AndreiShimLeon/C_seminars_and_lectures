// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void PrintArray (double[] array, string text)
    {
        Console.Write(text);
        for (int i = 0; i < array.Length; i++)
            Console.Write($"{array[i]} ");
        Console.WriteLine();
    } 
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

void Print2DArray(int [,] array, string text)
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



double[] MeanColumns(int [,] array)
{ 
    double[] columnMeans = new double[array.GetLength(1)];
    int countRow = 0;
    double sumRow = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {   
                sumRow += double.Parse(array[i,j].ToString());
                countRow++;
            }

        columnMeans[j] = Math.Round(sumRow/countRow,2);
        sumRow = 0;
        countRow = 0;
        }
    return columnMeans;
}
int [,] numbers = new int[3,3];

FillArray(numbers);
Print2DArray(numbers, "Оригинальный массив: ");
PrintArray(MeanColumns(numbers), "Средние по столбцам: ");