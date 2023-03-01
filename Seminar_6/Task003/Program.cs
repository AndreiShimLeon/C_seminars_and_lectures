// В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, 
// что такого элемента нет
int ReadInt(string text)
    {
        Console.WriteLine(text);
        return int.Parse(Console.ReadLine()!);
    }

void FillArray (int [,] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = rnd.Next(0,10);
        }
    }

void PrintArray(int [,] array, string text)
    {
        Console.WriteLine("\n");
        Console.WriteLine(text);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (array[i,j] >= 0)
                    Console.Write($" {array[i,j]} \t");
                else
                    Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
        }
    }
void FindElement(int [,] array, int number)
    {
        int switcher = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (array[i,j] == number)
                    {
                        Console.Write($" ({i}, {j}) ");
                        switcher = 1;
                    }
        }
        if (switcher == 0)
            Console.Write("Такого числа нет.");
    }

int i = ReadInt("Введите искомое число: ");

int [,] numbers = new int[5,5];

FillArray(numbers);
PrintArray(numbers, "Оригинальный массив: ");
FindElement(numbers, i);