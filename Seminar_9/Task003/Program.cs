// Найти сумму цифр числа

// int DigitSum(int number)
// {
//     if (number == 0) return 0;
//     else
//     {
//         Console.WriteLine(number);
//         return DigitSum(number / 10) + number%10;
//     }
// }

int DigitSum(int number)
{
    int sum = 0;
    if (number == 0) 
    {
        return sum;
    }
    else 
    {
        sum+=DigitSum(number / 10) + number%10;
        return sum;
    }
}

int number = 123123123;

Console.WriteLine(DigitSum(number));

