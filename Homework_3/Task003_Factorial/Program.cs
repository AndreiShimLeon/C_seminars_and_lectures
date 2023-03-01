// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine() ?? "0");

// Рекурсия
// int factorial(int number)
// {
//     if (number == 1 || number == 0)
//         return 1;
//     else
//         return number*factorial(number-1);
// }
// Console.WriteLine($"Факториал числа N равен {factorial(N)}");

// Через цикл
int factorial = 1;
for (int i = 1; i <= N; i++)
{
    factorial = factorial * i;
}
Console.WriteLine($"Факториал числа N равен {factorial}");