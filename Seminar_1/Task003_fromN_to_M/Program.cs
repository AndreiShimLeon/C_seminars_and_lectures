// Console.Write("Введите первое число ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число ");
// int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите  число N: ");
int numberC = int.Parse(Console.ReadLine());
int alt_numberC = numberC*-1;
int min = 0;
int max = 0;

if (numberC > alt_numberC)
{
    max = numberC;
    min = alt_numberC;
}
else
{
     max = alt_numberC;
     min = numberC;
}

int i = min;
while (i != max + 1)
{
    Console.WriteLine(i);
    i++;
}

