// Написать программу возведения числа А в целую стень B
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int Power(int numberA, int numberB)
{
    return numberB == 0 ? 1: numberA*Power(numberA, numberB-1);
}

int a = ReadInt("Enter A : ");
int b = ReadInt("Enter B : ");
Console.Write($"A^B: {Power(a, b)}");
