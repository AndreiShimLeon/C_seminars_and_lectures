// Найти расстояние между точками в пространстве 2D/3D

double distance(int[] dot1, int[] dot2, int dim) // метод для нахождения расстояния между точками в 2D и 3D
{
    double sum = 0;
    int i = 0;
    while (i < dim)
    {
        sum += Math.Pow((dot2[i]-dot1[i]),2);
        i++;
    }
    return Math.Sqrt(sum);
}


Console.WriteLine("Введите количество осей пространства: ");
int dimension = int.Parse(Console.ReadLine());
if (dimension != 2 && dimension != 3)
    Console.WriteLine("Вы ввели неверное количество осей. ");
else
{
    int[] firstDot = new int[dimension];
    int[] secDot = new int[dimension];
    // Первая точка 
    Console.WriteLine("Введите X координату первой точки: ");
    firstDot[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите Y координату первой точки: ");
    firstDot[1] = int.Parse(Console.ReadLine());
    if (dimension == 3)
    {
        Console.WriteLine("Введите Z координату первой точки: ");
        firstDot[2] = int.Parse(Console.ReadLine());
    }
    // Вторая точка 
    Console.WriteLine("Введите X координату второй точки: ");
    secDot[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите Y координату второй точки: ");
    secDot[1] = int.Parse(Console.ReadLine());
    if (dimension == 3)
    {
        Console.WriteLine("Введите Z координату второй точки: ");
        secDot[2] = int.Parse(Console.ReadLine());
    }
    // Вычисление расстояния между точками
    if (dimension == 3)
        Console.WriteLine($"Расстояние между точками ({firstDot[0]}, {firstDot[1]}, {firstDot[2]}) и ({secDot[0]}, {secDot[1]}, {secDot[2]}) составляет {distance(firstDot, secDot, dimension)}.");
    else   
        Console.WriteLine($"Расстояние между точками ({firstDot[0]}, {firstDot[1]}) и ({secDot[0]}, {secDot[1]}) составляет {distance(firstDot, secDot, dimension)}."); 
}