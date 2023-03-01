// int[] fillIntArray(int Length,int min,int max)
// {   
//     int[] array = new int[Length];
//     int i = 0;
//     while (i < Length)
//     {
//         array[i] = new Random().Next(min,max);
//         Console.Write(array[i] + " ");
//         i++;
//     }
//     return array;
// }

void fillIntArrayVoid(int [] array) // метод по заполнению массива целыми числами от 0 до 9
{   
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(1,10);
        i++;
    }
}

void printArray (int [] arr) // метод по печати массива с целыми числами
{
    int position = 0;
    while(position < arr.Length)
    {
        Console.Write(arr[position]);
        position++;
    }
}

int IndexOf(int[] Collection, int find) // метод по нахождению позиции числа в массиве
{
    int position = -1; // если элемента нет, то метод возвратит -1
    int index = 0;
    while (index < Collection.Length)
    {
        if (Collection[index] == find)
        {
        position = index;
        break; // смотрим только первое вхождение
        }
        index++;
    }
    return position;
}

int[] array = new int[100]; // определили массив из 100 элементов

fillIntArrayVoid(array); // заполнили массив array
printArray(array); // распечатали массив array
Console.WriteLine();

int pos = IndexOf(array, 4); // ищем индекс числа 4 в массиве

Console.WriteLine(pos);