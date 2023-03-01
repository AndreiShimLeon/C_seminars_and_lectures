// Написать программу преобразования десятичного числа в двоичное

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

string DecimalToBinary(int number)
{
    int remainder = 0;
    string notBinaryYet = "";
    int reserveNumber = number;
    while (reserveNumber != 0)
    {
        remainder = reserveNumber%2;
        reserveNumber = reserveNumber/2;
        notBinaryYet += $"{remainder}";
    }
    string binary = "";
    for (int i = 0; i < notBinaryYet.Length; i++)
    {
        binary += notBinaryYet[notBinaryYet.Length - i - 1];
    }
    return binary;
}

int number = ReadInt("Введите число");
Console.WriteLine(DecimalToBinary(number));
