// Задать массив из 8 элементов, заполненных нулями
// и единицами вывести их на экран

int[] CreateArray (int length, int lower, int higher)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(lower, higher+1);
    return array;
} 

void PrintArray (int[] array)
{
    Console.Write("\nArray: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
} 

int[] numbers = CreateArray(8,0,1); // заполняем массив 
PrintArray(numbers);
