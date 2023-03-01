// Найти сумму цифр числа

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int SumDigits(int number)
{
    return number == 0 ? 0 : SumDigits(number/10) + number%10;
}

int number = ReadInt("Enter a number : ");

Console.Write($"Sum of digits : {SumDigits(number)}");
