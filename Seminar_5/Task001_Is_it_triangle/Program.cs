// Выяснить являются ли три числа сторонами треугольника
// Неравенство треугольника - каждая сторона должна быть меньше суммы других


int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

bool CheckSides (int A, int B, int C) => A < B + C && B < A + C && C < A + B;

int a = ReadInt("enter 1st side of triangle: ");
int b = ReadInt("enter 2nd side of triangle: ");
int c = ReadInt("enter 3d side of triangle: ");

Console.WriteLine(CheckSides (a, b, c) ? "Triangle" : "Not Triangle");

