// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double Factorial(double number)
{
    if (number == 0 || number == 1) return 1;
    return number*Factorial(number-1);
}

for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"!{i} = {Factorial(i)}");
    
}
