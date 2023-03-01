int[] array = {1,23,31,4,25,76,7,58,25};

int n = array.Length; //возвращает длину массива (количество элементов)

int find = 25; // будем искать это исло
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // здесь  будем искать толко первый найденный элемент
    }
    index++;
}

