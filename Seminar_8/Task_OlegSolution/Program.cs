void FillArray(int[] array, int leftSide, int rightSide)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(leftSide, rightSide);
}
void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Count<T>(T[] array, T value) where T : IComparable<T>
{
    int count = 0;
    foreach (T element in array)
        if (element.Equals(value))
            count++;
    return count;
}
bool ContainsBefore<T>(T[] array, int index, T value) where T : IComparable<T>
{
    for (int i = 0; i < index; i++)
        if (array[i].Equals(value))
            return true;
    return false;
}
int CountUniques<T>(T[] array) where T : IComparable<T>
{
    int uniques = 0;
    for(int i=0;i<array.Length;i++)
        if(!ContainsBefore(array, i, array[i]))
            uniques++;
    return uniques;
}
T[] Distinct<T>(T[] array) where T: IComparable<T>
{
    T[] result = new T[CountUniques(array)];
    int index = 0;
    for(int i=0;i<array.Length;i++)
        if(!ContainsBefore(array, i, array[i]))
        {
            result[index] = array[i];
            index++;
        }
    return result;
}
float CountFrequency<T>(T element, T[] array) where T: IComparable<T> => array.Count(c => c.Equals(element)) / (float)array.Length * 100;
int length = ReadInt("Enter length of array: ");
int[] array = new int[length];
int leftSide = ReadInt("Enter left side of array elements diaposon: ");
int rigthSide = ReadInt("Enter right side of array elements diaposon: ");
FillArray(array, leftSide, rigthSide);
Console.Write("Your array: ");
PrintArray(array);
int[] uniques = array.Distinct().ToArray();
foreach (int element in uniques)
    Console.WriteLine($"Элемент {element} встречается {Count(array, element)} раз. Частота {CountFrequency(element, array)}%");
Console.Write("Enter a string: ");
string str = Console.ReadLine()!;
char[] uniqueChars = Distinct(str.ToCharArray());
foreach (char element in uniqueChars)
    Console.WriteLine($"Элемент {element} встречается {Count(str.ToCharArray(), element)} раз. Частота {CountFrequency(element, str.ToCharArray())}%");