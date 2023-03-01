// Удалить вторую цифру трёхзначного числа

int number = 378;

int firstDigit = number/100;
int secondDigit = (number - 100*firstDigit)/10;
int thirdDigit = number - 100*firstDigit - 10*secondDigit;

int newNumber = firstDigit*10+thirdDigit;
Console.WriteLine(newNumber);
