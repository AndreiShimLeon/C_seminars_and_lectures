// Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// Пример: Есть набор данных

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// частотный массив может быть представлен так:

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Если набор данных - таблица

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// на выходе ожидаем получить

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Пример частотного массива для текстовых данных: Входные данные:

// Частотный анализ – это один из методов криптоанализа, 
// основывающийся на предположении о существовании нетривиального 
// статистического распределения отдельных символов и их последовательностей 
// как в открытом тексте, так и шифрованном тексте, которое с точностью 
// до замены символов будет сохраняться в процессе шифрования и дешифрования.

// Частотный анализ может выглядеть так

// Символ пробел/space встречается 41 раз. Частота 12.28%
// Символ о встречается 38 раз.  Частота 11.38%
// Символ и встречается 26 раз.  Частота 7.78%
// Символ т встречается 25 раз.  Частота 7.49%
// Символ е встречается 23 раза. Частота 6.89%
// Символ с встречается 21 раз.  Частота 6.29%
// Символ н встречается 20 раз.  Частота 5.99%
// Символ а встречается 20 раз.  Частота 5.99%
// Символ в встречается 16 раз.  Частота 4.79%
// Символ р встречается 12 раз.  Частота 3.59%
// Символ л встречается 10 раз.  Частота 2.99%
// Символ к встречается 9 раз.   Частота 2.69%
// Символ д встречается 9 раз.   Частота 2.69%
// Символ п встречается 6 раз.   Частота 1.80%
// Символ я встречается 6 раз.   Частота 1.80%
// Символ м встречается 6 раз.   Частота 1.80%
// Символ ь встречается 5 раз.   Частота 1.50%
// Символ ы встречается 5 раз.   Частота 1.50%
// Символ з встречается 4 раза.  Частота 1.20%
// Символ х встречается 3 раза.  Частота 0.90%
// Символ ш встречается 3 раза.  Частота 0.90%
// Символ ф встречается 3 раза.  Частота 0.90%
// Символ ч встречается 3 раза.  Частота 0.90%
// Символ й встречается 3 раза.  Частота 0.90%
// Символ , встречается 3 раза.  Частота 0.90%
// Символ щ встречается 2 раза.  Частота 0.60%
// Символ ю встречается 2 раза.  Частота 0.60%
// Символ у встречается 2 раза.  Частота 0.60%
// Символ г встречается 2 раза.  Частота 0.60%
// Символ ж встречается 1 раз.   Частота 0.30%
// Символ э встречается 1 раз.   Частота 0.30%
// Символ – встречается 1 раз.   Частота 0.30%
// Символ б встречается 1 раз.   Частота 0.30%
// Символ ц встречается 1 раз.   Частота 0.30%
// Символ . встречается 1 раз.   Частота 0.30%
// 
void PrintArray(string [,] array, string text)
    {
        Console.WriteLine("\n");
        Console.WriteLine(text);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($" {array[i,j]} \t");
        Console.WriteLine();
        }
    }
string ArraytoString(int[] array)
{
    string arrayString = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayString = arrayString + array[i].ToString();
    }    
    return arrayString;
}
string [] Frequency(string LookFor, string numbers)
{
    string [] frequency = new string[3];
    double freq = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (LookFor == numbers[i].ToString()) count++;
    }
    double countDouble = double.Parse(count.ToString());
    double stringLength = double.Parse((numbers.Length).ToString());
    freq = countDouble/stringLength*100;

    frequency[0] = LookFor;
    frequency[1] = count.ToString();
    frequency[2] = freq.ToString();
    return frequency;
}
int CountElements(string numbers)
{
    int flag = 0;
    char LookFor;
    string individuals = String.Empty;
    int count = 0;
    individuals = individuals + numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        LookFor = numbers[i];
        for (int j = 0; j < individuals.Length; j++)
        {
            if(LookFor==individuals[j])
            {
                flag = 1;
            }   
        }
        if(flag == 1) 
        {
            individuals+=LookFor;
            count++;
        }
    }
    return count;
}
bool KnownElementInFirstColumn(string LookFor, string [,] matrix)
{
    int flag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(matrix[i,0] == LookFor) flag = 1;
    }
    if(flag == 1) return true;
    else return false;
}
string [,] Frequencies (int[] array)
{
    string str = ArraytoString(array);
    
    // int count = CountElements(str);
    int count = str.Length;
    Console.WriteLine(count);
    string []element = new string [3];
    string [,] newMatrix  = new string [count,3];
    for (int i = 0; i < count; i++)
    {
        if (!KnownElementInFirstColumn(str[i].ToString(), newMatrix))
        {
            element = Frequency(str[i].ToString(), str); 
            newMatrix[i,0] = element[0];
            newMatrix[i,1] = element[1];
            newMatrix[i,2] = element[2];
        }
    }
    return newMatrix;
}
int [] numbers = new int []{1,9,9,0,2,8,0,9};

string [,] summary = Frequencies(numbers);
PrintArray(summary, "Итог:");
