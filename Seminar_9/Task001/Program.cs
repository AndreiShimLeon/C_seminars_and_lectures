// Показать натуральные числа от N до 1, N задано

// void PrintTillN(int N)
// {
//     Console.Write($"{N} ");
//     if (N == 1)
//         Console.WriteLine("Done");
//     else
//         PrintTillN(N - 1);
// }

// Console.WriteLine("Enter number: ");
// int N = int.Parse(Console.ReadLine()!);
// PrintTillN(N);

// Показать натуральные числа от M до N, N и M заданы

void PrintNaturalsFromNtoM(int N, int M)
{
    Console.Write($"{N} ");
    if (N == M)
        Console.WriteLine("Done");
    else
        PrintNaturalsFromNtoM(N - 1, M);
}

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine()!);
if (N > M)
    PrintNaturalsFromNtoM(N, M);
else
    PrintNaturalsFromNtoM(M, N);
