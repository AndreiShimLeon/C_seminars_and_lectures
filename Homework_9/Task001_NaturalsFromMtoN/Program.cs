// Показать натуральные числа от M до N, N и M заданы
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void Naturals(int numberA, int numberB)
{
    if (numberA == numberB)
        Console.Write($"{numberB} ");
    else
    {
        Naturals(numberA, numberB - 1);
        Console.Write($"{numberB} ");
    }
}

int m = ReadInt("Enter number M: ");
int n = ReadInt("Enter number N: ");
if (m > n)
    Naturals(n, m);
else
    Naturals(m, n);
