// Написать программу копирования массива

void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        Console.Write($" | {array[i]} | ");
        Console.WriteLine();
    }
int ReadInt(string text)
    {
        Console.Write(text);
        return int.Parse(Console.ReadLine()!);
    }

int [] RandomArrayCreation(int size, int min, int max)
    {
        Random random = new Random();
        int[]array = new int[size];
        for (int i = 0; i < size; i++) array[i] = random.Next(min, max+1);
        return array;
    }

int [] ManualArrayCreation(int size)
    {
        int[]array = new int[size];
        for (int i = 0; i < size; i++) array[i] = ReadInt($"Enter element with index {i}: ");
        return array;
    }

int[] CopyingArray(int [] array)
{
    int [] CopiedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) CopiedArray[i] = array[i];
    return CopiedArray;
}

int size = ReadInt("Enter a size of an array to be created: ");
int[] array = RandomArrayCreation(size, 0, 10);
int[] CopiedArray = CopyingArray(array);

Console.WriteLine("Original array:");
PrintArray(array);
Console.WriteLine("Copied array:");
PrintArray(array);