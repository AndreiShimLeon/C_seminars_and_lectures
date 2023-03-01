// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number = 13;
Console.WriteLine("Введите число, чтобы проверить, кратно ли оно " + number + ": ");
int enteredNumber = int.Parse(Console.ReadLine());

if ((Convert.ToDouble(enteredNumber)/Convert.ToDouble(number) < 1) && Convert.ToDouble(enteredNumber)/Convert.ToDouble(number)*-1 < 1)
    Console.WriteLine("Частное меньше единицы");
else
{
    if (enteredNumber%number == 0)
        Console.WriteLine("Введенное число кратно " + number);
    else
        Console.WriteLine("Введенное число не кратно " + number + "\nОстаток от деления равен " + enteredNumber%number);
}
