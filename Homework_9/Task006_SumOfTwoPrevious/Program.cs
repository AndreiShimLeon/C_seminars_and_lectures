/* Написать программу показывающие первые N чисел,
для которых каждое следующее равно сумме двух предыдущих.
Первые два элемента последовательности задаются пользователем */

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int SpecialSum(int f1, int f2, int size)
{
    return size == 1
        ? f1
        : size == 2
            ? f2
            : SpecialSum(f2, f1 + f2, size - 1);
}

int f1 = ReadInt("Enter the first element of the sequence: ");
int f2 = ReadInt("Enter the second element of the sequence: : ");
int n = ReadInt("Enter a size of the sequence: ");
for (int i = 1; i <= n; i++)
{
    Console.Write($"{SpecialSum(f1, f2, i)} ");
}
