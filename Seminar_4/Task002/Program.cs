// Задать массив из 12 элементов, заполненных числами из [0,9].
//  Найти сумму положительных/отрицательных элементов массива

int lowerLimit = -10;
int upperLimit = 10;
int posSum = 0;
int negSum = 0;

int[] numbers = new int[12]; // задаем массив

for (int i = 0; i < numbers.Length; i++) // заполнение массива
{
    numbers[i] = new Random().Next(lowerLimit,upperLimit);
}

for (int i = 0; i < numbers.Length; i++) // суммирование элементов массива
{
    if (numbers[i] > 0)
        posSum += numbers[i];
    else
        negSum += numbers[i];
}

Array.Sort(numbers);

string result = "Массив: ";
for (int i = 0; i < numbers.Length; i++)
{
    result = result + $" {numbers[i]}";
}
Console.WriteLine(result);

Console.WriteLine($"Сумма отрицательных элементов равна: {negSum}");
Console.WriteLine($"Сумма положительных элементов равна: {posSum}");