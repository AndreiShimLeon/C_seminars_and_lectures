// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти, чтобы узнать диапазоны возможных координат: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1) 
    Console.WriteLine("Координата х принадлежит множеству (0;+inf), а координата y - (0;+inf).");
else if (quarter == 2) 
    Console.WriteLine("Координата х принадлежит множеству (-inf;0), координата y - (0;+inf).");
else if (quarter == 3) 
    Console.WriteLine("Координата х принадлежит множеству (-inf;0), координата y - (-inf;0).");
else if (quarter == 4) 
    Console.WriteLine("Координата х принадлежит множеству (0;+inf), координата y - (-inf;0).");
else
    Console.WriteLine("Введен неправильный номер четверти.");