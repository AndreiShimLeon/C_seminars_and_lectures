// Определить, присутствует ли в заданном массиве, некоторое число
int lowerLimit = 0;
int upperLimit = 10;
Console.WriteLine("Введите число: ");

int lookFor = int.Parse(Console.ReadLine() ?? "0"); //51; // ищем число
int count = 0;

int[] numbers = new int[12]; // задаем массив
for (int i = 0; i < numbers.Length; i++) // заполнение массива
{
    numbers[i] = new Random().Next(lowerLimit,upperLimit);
}

string result = "Массив: \n"; // Печать  массива
for (int i = 0; i < numbers.Length; i++)
{
    result = result + $" {numbers[i]}";
}
Console.WriteLine(result);

for (int i = 0; i < numbers.Length; i++) // поиск элемента
{
    if (numbers[i] == lookFor)
    {
        Console.WriteLine(" Элемент в массиве присутствует. ");
        count++;
        break;
    }
}

if (count == 0) Console.WriteLine(" Элемент в массиве отсутствует. ");

// bool exist = true;
// Console.WriteLine(exist);
// bool notExist = false;
// Console.WriteLine(notExist);

