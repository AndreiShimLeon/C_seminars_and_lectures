// Показать числа Фибоначчи меньше N
// F0 = 1, F1 = 1, Fi = Fi-1 + Fi-2

int ReadInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int Fibonacci (int number) // рекурсия
{
    if (number == 0) 
        return 0;
    else if (number == 1) 
        return 1;
    else
        return (Fibonacci(number - 1) + Fibonacci(number - 2));
}

void FibonacciRow(int number)
{
    int count = 0;
    for (int i = 0; i <= number; i++)
    {
        Console.Write($"|F{i} = {Fibonacci(i)}|\t" );
        count++;
        if (count%3==0) Console.Write("\n");
    }
}

int number = ReadInt("Введите N: ");
FibonacciRow(number);