// В матрице чисел найти сумму элементов главной диагонали 
// Слева направо
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

int diagonalSum(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,i];
        }
        return sum;
    }
int [,] matrix = new int[5,5];
FillArray(matrix);
int sum = diagonalSum(matrix);
PrintArray(matrix, "Оригинальный массив: ");
Console.WriteLine($"Сумма элементов главной диагонали: {sum}\n");