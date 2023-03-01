void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
int[] CreateArray(int length, int lowest, int hightest)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest, hightest + 1);
    return array;
}
bool Constains(int[] array, int value)
{
    foreach(int element in array)
        if (element == value)
            return true;
    return false;
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int length = ReadInt("Enter size of array: ");
int lowest = ReadInt("Enter left part of array range: ");
int hightest = ReadInt("Enter right part of array range: ");
int[] array = CreateArray(length, lowest, hightest);
PrintArray(array);
int value = ReadInt("Enter element to find: ");
Console.WriteLine(Constains(array, value) ? "There is element into array" : "There is no element into array" );