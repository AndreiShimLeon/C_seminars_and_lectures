// Показать сумму чисел от 1 до A
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = 1; i <= A; i++)
    sum += i;
Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum}");