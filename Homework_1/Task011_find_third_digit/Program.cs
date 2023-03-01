// Найти третью цифру числа или сообщить, что её нет
int pow10(int x) // метод возведения 10 в степень х
{
    int z = Convert.ToInt32(Math.Pow(10,x));
    return z;
}
int[] numberCut(int enterNumber) // метод нарезки числа в массив 
{
    string numberString = Convert.ToString(enterNumber);
    int[] array = new int[numberString.Length];
    int n = 0;
    int sum = enterNumber;
    while(n < numberString.Length)
    {
        array[n] = sum/pow10(numberString.Length-n-1);
        sum -= array[n]*pow10(numberString.Length-n-1);
        n++;
    }
    return array;
}

void printArray(int[] array, int length)
{
    int n = 0;
    while (n < length)
    {
        Console.WriteLine(array[n]);
        n++;
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int position = 3; // порядковый номер цифры в числе, который нам нужен
string numberString = Convert.ToString(number);
if (numberString.Length < 3)    Console.WriteLine("В числе меньше " + position + " цифр");
else
{
    int[] array = numberCut(number);
    Console.WriteLine(position + "-я цифра слева в числе " + number + " - " + array[position-1]);
    Console.WriteLine(position + "-я цифра справа в числе " + number + " - " + array[array.Length - position]);
}

// Печать массива
// int[] x = numberCut(number);
// printArray(x, numberString.Length);