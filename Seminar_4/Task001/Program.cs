// Задать массив из 8 элементов и вывести их на экран

// int [] numbers = {1,3,4,6,7,8,9,10};

int [] numbers = new int [8];
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "0");
}

string result = "Массив: ";
for (int i = 0; i < numbers.Length; i++)
{

    result = result + $" {numbers[i]}";
}
    Console.Write(result);