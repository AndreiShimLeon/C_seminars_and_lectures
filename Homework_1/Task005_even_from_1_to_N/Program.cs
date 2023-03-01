// Показать четные числа от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if ((N == 1) || (N == 0)) // Если N = 0 или 1
{
    Console.WriteLine("На отрезке [1;" + N + "] нет четных чисел");
}

int index = 2;
while (index <= N) 
{
    Console.WriteLine(index);
    index=index+2;
}

// Показывает от N до 1

// while (N != 0)
// {
//     if (N%2 == 0)
//     {
//         Console.WriteLine(N);
//         N -= 2;
//         continue;
//     }
//     else N--;
// }
