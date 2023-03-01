// В двумерном массиве заменить элементы, 
// у которых оба индекса чётные на их квадраты
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

void ReplaceWithSquares(int [,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (i%2==0 && j%2==0)
                    array[i,j] = array[i,j]*array[i,j];
        }
}
int m = ReadInt("Enter a number of rows: ");
int n = ReadInt("Enter a number of columns: ");

int[,]numbers = new int[m,n];
FillArray(numbers);
PrintArray(numbers, "Original matrix: ");
ReplaceWithSquares(numbers);
PrintArray(numbers, "New matrix: ");