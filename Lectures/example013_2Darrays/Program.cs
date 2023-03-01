
// // string.Empty
// string [,] table = new string[2,5];
// table [1,2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine ($"-{table[rows,columns]}-");
//     }
// }


void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

void FillArray(int [,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(0,10);
        }
    }
}
int [,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);