// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2
// b1 k1 и b2 и k2 заданы

int ReadInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

void CrossPoint (int k1, int b1, int k2, int b2)
{
    int x = (b1 - b2)/(k2-k1);
    int y = (k2*b1 - k1*b2)/(k2-k1);
    Console.WriteLine($"Точка пересечения заданных прямых ({x}, {y}).");
}

Console.WriteLine("Для нахождения точки пересечения двух прямых вида y = kx + b ");
int k1 = ReadInt("Введите k1: ");
int b1 = ReadInt("Введите b1: ");
int k2 = ReadInt("Введите k2: ");
int b2 = ReadInt("Введите b2: ");

CrossPoint(k1, b1, k2, b2);