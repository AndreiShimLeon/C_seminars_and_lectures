// Написать программу замену элементов массива на противоположные
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

string result = "Массив: \n"; // Печать оригинального массива
for (int i = 0; i < numbers.Length; i++)
{
    result = result + $" {numbers[i]}";
}
Console.WriteLine(result);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i]*-1;
}

result = "Массив c элементами, противоположными по знаку: \n"; // Печать  массива c элементами, противоположными по знаку
for (int i = 0; i < numbers.Length; i++)
{
    result = result + $" {numbers[i]}";
}
Console.WriteLine(result);
