// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber > 5) 
    Console.WriteLine("Введный номер дня недели - выходной.");
else
    Console.WriteLine("Введный номер дня недели - будний.");