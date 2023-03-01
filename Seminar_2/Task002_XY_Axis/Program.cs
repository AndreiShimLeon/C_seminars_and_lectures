// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату X: ");
int xNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int yNumber = int.Parse(Console.ReadLine());

if (xNumber > 0)
{
    if (yNumber > 0) Console.WriteLine($"Точка ({xNumber}, {yNumber}) лежит в I четверти"); // ++
    else Console.WriteLine($"Точка ({xNumber}, {yNumber}) лежит в IV четверти"); //+-
}
else
{
    if (yNumber > 0) Console.WriteLine($"Точка ({xNumber}, {yNumber}) лежит в II четверти");// -+
    else Console.WriteLine($"Точка ({xNumber}, {yNumber}) лежит в III четверти"); //--
}