// 100 шкафчиков с закрытыми дверями. Каждый раз меняют состояние шкафчики, чьи номера кратны i=i+1
int changeStatus(int number)
{
    if (number == 1)
        number = 0;
    else
        number = 1;
    return number;
}


int[] lockers = new int[100];
int i = 0;
int j = 0;
while (i < 100)
{
    lockers[i] = 1;
    i++;
}
i = 0;
Console.WriteLine("смотрим на начальный Массив ");
while (i < 100) // смотрим на начальный Массив
{
    Console.Write(lockers[i]);
    i++;
}

i = 1;
while (i <= 100)
{
    i++;
    while (j < 100)
    {
        if ((j+1)%i == 0) 
        {
            lockers[j] = changeStatus(lockers[j]);
        }
    j++;
    }
    j = 0;
}

i = 0;
Console.WriteLine("\nсмотрим на измененный Массив ");
while (i < 100) // смотрим на измененный Массив
{
    if (lockers[i] == 1)
        Console.Write(i+1 +" ");
    i++;
}
// 1001000010000001000000001000000000010000000000001000000000000001000000000000000010000000000000000001