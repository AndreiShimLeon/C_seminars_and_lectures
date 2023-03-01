// Написать программу, которая в двумерном массиве заменяет 
// строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).
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


int [,] TransMatrix(int[,] array)
    {
        // int [,] newArray = new int [array.GetLength(1),array.GetLength(0)];
        int [,] newArray  = new int [array.GetLength(0),array.GetLength(1)];
        for (int i = 0; i <array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                newArray[i,j] = array[j,i];
            }
        
        }
        return newArray;
    }

void NewTransMatrix(int[,] array)
    {
        int temp = 0;
        for (int i = 0; i <array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(0); j++)
            {
                temp = array[j,i];
                array[j,i] = array[i,j];
                array[i,j] = temp;
            }
        
        }
    }

int [,] matrix = new int[5,5];
FillArray(matrix);
PrintArray(matrix, "Оригинальный массив: ");
int [,] newMatrix = TransMatrix(matrix);
NewTransMatrix(matrix);

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    // PrintArray(newMatrix, "Новый массив: ");
    PrintArray(matrix,"Новый массив: ");
}
else
{
    Console.WriteLine("Мы не можем перевернуть не квадратный массив. ");
}

