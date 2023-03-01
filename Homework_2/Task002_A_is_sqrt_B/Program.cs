// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
int max = numberA;
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int min = numberB;

if (numberB > numberA) 
    {
        max = numberB;
        min = numberA;
    }
if (Math.Pow(min, 2) == max)
    Console.WriteLine($"Число {max} является квадратом числа {min}.");
else
    Console.WriteLine("Ни одно из введенных чисел не является квадратом другого.");