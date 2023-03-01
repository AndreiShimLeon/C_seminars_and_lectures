// Показать последнюю цифру трёхзначного числа

int numberA = 321;
int firstDigit = numberA/100;
int secondDigit = (numberA-firstDigit*100)/10;
int thirdDigit = (numberA-firstDigit*100-secondDigit*10);

Console.WriteLine(thirdDigit);