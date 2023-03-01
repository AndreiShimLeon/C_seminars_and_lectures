// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число N: ");

int N = int.Parse(Console.ReadLine());

int k = 1;
while (k <= N)
{
    Console.Write(k + "^2 -> ");
    Console.WriteLine(Math.Pow(k,2)); // k*k
    k++;
}
