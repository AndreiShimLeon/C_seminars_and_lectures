// Показать вторую цифру трёхзначного числа

int numberA = 591;
int firstDigit = numberA/100;
int secondDigit = (numberA-firstDigit*100)/10;

Console.WriteLine(secondDigit);