// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = 31;

int firstDigit = number/10;
int secondDigit = number-firstDigit*10;

if (secondDigit > firstDigit) 
    Console.WriteLine(secondDigit);
else
    Console.WriteLine(firstDigit);
