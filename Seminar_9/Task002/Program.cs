// Показать натуральные числа от 1 до N, N задано
void PrintTillN(int N)
{
    if (N!=0)
    {
        PrintTillN(N-1);
        Console.Write($"{N} ");
    }
}

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
PrintTillN(N);
