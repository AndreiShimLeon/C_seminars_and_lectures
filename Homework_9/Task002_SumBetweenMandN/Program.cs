// Найти сумму элементов от M до N, N и M заданы

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int SumNaturals(int numberA, int numberB)
{
    if (numberA == (numberB - 1) || numberA == numberB)
        return 0;
    else
    {
        return SumNaturals(numberA, numberB - 1) + (numberB - 1);
    }
}

int m = ReadInt("Enter number M: ");
int n = ReadInt("Enter number N: ");
if (m > n)
    Console.Write($"Sum of numbers between M and N: {SumNaturals(n, m)}");
else
    Console.Write($"Sum of numbers between M and N: {SumNaturals(m, n)}");
