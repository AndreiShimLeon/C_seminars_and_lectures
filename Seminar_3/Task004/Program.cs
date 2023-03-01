// Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
// string numberStr = Convert.ToString(number);

// int i = numberStr.Length; // 6
// var numberN = Math.Floor(Math.Log10(number) + 1); // 6

int i = 0;
int x = number;
while (x != 0)
 {
    x = x/10;
    i++;
 }

Console.WriteLine($"Количество цифр в числе {number} равно {i}");
// Console.WriteLine(123%10);


