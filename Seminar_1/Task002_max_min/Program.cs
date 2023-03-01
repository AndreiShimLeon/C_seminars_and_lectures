Console.Write("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.Write("Большее число - " + max + ". Меньшее число - " + min);