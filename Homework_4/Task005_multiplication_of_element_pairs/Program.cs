// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] CreateRandomArray (int length, int lower, int higher)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(lower, higher+1);
    return array;
} 

void PrintArray (int[] array, string text)
{
    Console.Write(text);
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
} 

int[] MultiplyPairs(int[] array)
{
    
    int[] newArray = new int[array.Length/2];
    int index = 0;
    while (index < array.Length/2)
    {
        newArray[index] = array[index]*array[array.Length - index - 1]; 
        index++;
    }
    Console.WriteLine($"В массиве {index} пар.");
    return newArray;
}

int[] number = CreateRandomArray(13,1,9);
PrintArray(number, "Оригинальный массив:\n");
number = MultiplyPairs(number);
PrintArray(number, "Массив с произведениями пар элементов оригинального массива:\n");

