// Деление в целых числах
int numberA = 10;
int numberB = 5;
Console.WriteLine(numberA / numberB); 
// Деление вещественных чисел

double numberC = 12;
double numberD = 5;
Console.WriteLine(numberC / numberD); 

// Случайные целые числа

int numberE = new Random().Next(1, 100); // Случайное число от 1 до 99 включительно
string text1 = "1st number ";
Console.Write(text1);
Console.WriteLine(numberE); 

int numberF = new Random().Next(100, 200); // Случайное число от 100 до 199 включительно
string text2 = "2nd number ";
Console.Write(text2);
Console.WriteLine(numberF); 

int result = numberE + numberF;
string text3 = "sum ";
Console.Write(text3);
Console.WriteLine(result); 