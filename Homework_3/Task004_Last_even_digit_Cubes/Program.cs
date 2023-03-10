// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

// Так как результат возведения четного числа в куб всегда будет четным и наоборот, берем за основу код первого задания и добавляем в цикл условие четности
Console.Write($"\nКубы чисел от 1 до {N}, которые заканчиваются на четную цифру: ");
for (int i = 1; i <= N; i++)
{  
    if (i%2 == 0) // или if (Math.Pow(i, 3)%2 == 0) - ищем в результате возведения в куб последнюю цифру и проверяем ее на четность
        Console.Write($"\n{i}^3 = {Math.Pow(i, 3)}");
}
