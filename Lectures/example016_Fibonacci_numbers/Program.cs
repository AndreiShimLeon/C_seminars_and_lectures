// Числа Фибоначчи F(1) = 1 F(2) = 1 F(n) = F(n-1) + F(n-2)
double Fibonacci(int number)
{
    if (number == 0) return 0;
    if (number == 1) return 1;
    if (number == -1) return -1;
    return Fibonacci(number-1) + Fibonacci(number-2);
}

for (int i = 1; i < 52; i++)
{
    Console.WriteLine($"F({i}) = {Fibonacci(i-1)} + {Fibonacci(i-2)} = {Fibonacci(i)}");
}
