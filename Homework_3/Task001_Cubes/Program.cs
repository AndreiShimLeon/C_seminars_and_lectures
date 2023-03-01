// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= N; i++)
{  
    Console.Write($"\n{i}^3 = {Math.Pow(i, 3)}");
}
