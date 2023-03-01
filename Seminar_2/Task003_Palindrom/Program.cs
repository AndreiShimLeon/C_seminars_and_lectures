// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

int firstDigit = number / 10000; // 12345 1
int secondDigit = (number - firstDigit * 10000) / 1000; //12345 - 10000* = 2345/1000 = 2
int thirdDigit = (number - firstDigit * 10000 - secondDigit * 1000) / 100;
int fourthDigit = (number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100) / 10;
int fifthDigit = number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100 - fourthDigit * 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    Console.WriteLine("Вы ввели палиндром!");
else
    Console.WriteLine("Число не палиндром"!);

// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);
// Console.WriteLine(thirdDigit);
// Console.WriteLine(fourthDigit);
// Console.WriteLine(fifthDigit);
