// Возведите число А в натуральную степень B используя цикл
// степень не отрицательная
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

double result = 1;

// result = Math.Pow(A, B);

for (int i = 0; i < B; i++)
    result = result*A;
Console.WriteLine($"\n{A} в степени {B} равно {result}");



