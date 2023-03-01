// По заданному номеру дня недели вывести его название

int day_number = 0;

while ((day_number < 1) || (day_number > 7))
{
    Console.WriteLine("Введите номер дня недели: ");
    day_number = int.Parse(Console.ReadLine());
    if ((day_number < 1) || (day_number > 7)) 
        Console.WriteLine("Неверный ввод");
}

string[] week = new string[]{"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресение"};
Console.WriteLine(week[day_number-1]);