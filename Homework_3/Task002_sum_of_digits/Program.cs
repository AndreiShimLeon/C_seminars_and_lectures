// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine() ?? "0");
int saveNumber = number; // переменная для сохранения числа перед подсчетом цифр
int countDigits = 0; 
int digit = 0;
int sum = 0;
int power = 1;

// Cчитаем цифры в числе
while (number != 0)
{
    number = number/10;
    countDigits++;
}
number = saveNumber;


// вырезаем цифры из числа и суммируем
for (int i = 1; i <= countDigits; i++) 
{
    digit = Math.Abs((number % (power*10))/power);
    power = power*10;
    sum += digit;
}

Console.WriteLine($"Сумма цифр числа {number} равна {sum}.");
