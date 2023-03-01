// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB)
    Console.Write("Число " + numberB + " является квадратом числа " + numberA);
else if (numberB * numberB == numberA)
    Console.Write("Число " + numberA + " является квадратом числа " + numberB);
else 
    Console.Write("Ни одно из введенных чисел не является квадратом другого");
