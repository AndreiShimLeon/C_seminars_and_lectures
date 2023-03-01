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
string [,] Frequencies (string numbers)
{
       
    // int count = CountElements(str);
    int count = numbers.Length;
    Console.WriteLine(count);
    string []element = new string [3];
    string [,] newMatrix  = new string [count,3];
    for (int i = 0; i < count; i++)
    {
        if (!KnownElementInFirstColumn(numbers[i].ToString(), newMatrix))
        {
            element = Frequency(numbers[i].ToString(), numbers); 
            newMatrix[i,0] = element[0];
            newMatrix[i,1] = element[1];
            newMatrix[i,2] = element[2];
        }
    }
    return newMatrix;
}
string numbers = "привет ребята как дела";

string [,] summary = Frequencies(numbers);
PrintArray(summary, "Итог:");