// Написать программу вычисления функции Аккермана

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int AckermannFucntion(int numberA, int numberB)
{
    if (numberA == 0)
        return numberB+1;
    else if (numberB == 0)
        return AckermannFucntion(numberA - 1, 1);
    else
        return AckermannFucntion(numberA - 1, (AckermannFucntion(numberA, numberB-1)));
}

int m = ReadInt("Enter m : ");
int n = ReadInt("Enter n : ");
Console.Write($"Ackermann Function: {AckermannFucntion(m, n)}");
