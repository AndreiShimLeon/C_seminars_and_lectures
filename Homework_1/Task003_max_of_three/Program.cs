// Найти максимальное из трех чисел

int numberA = 123;
int numberB = 2022;
int numberC = 301;

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

// Через массив

// int[] numbers = new int[]{numberA, numberB, NumberC}; 
// int max = numbers[0];
// int i = 1;
// while ((i+1) < numbers.Length)
// {
//     if (numbers[i] > max) max = numbers[i];
//     i++;
// }

Console.WriteLine(max);

