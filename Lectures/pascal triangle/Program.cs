// Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника
void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < (matrix.GetLength(0)-i); k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]%2!=0)   Console.Write("* ");
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}

int rows = 128;

int [,] pascalTriangle(int rows)
{
    int [,] triangle = new int [rows,rows];
    for (int i = 0; i < rows; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }

    for (int i = 2; i < rows; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i,j] = triangle[i-1,j-1] + triangle[i-1,j];
        }
    }
    return triangle;
}



PrintMatrix(pascalTriangle(rows));