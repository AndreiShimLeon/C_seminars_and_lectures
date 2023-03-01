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

string [] Frequency(string lookFor, string numbers)
{
    string [] frequency = new string[3];
    double freq = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (lookFor == numbers[i].ToString()) count++;
    }
    double countDouble = double.Parse(count.ToString());
    double stringLength = double.Parse((numbers.Length).ToString());
    freq = Math.Round(countDouble/stringLength*100,2);

    frequency[0] = lookFor;
    frequency[1] = count.ToString();
    frequency[2] = freq.ToString()+"%";
    return frequency;
}
int CountElements(string numbers)
{
    int flag = 0;
    char lookFor;
    string individuals = String.Empty;
    int count = 1;
    individuals = numbers[0].ToString();
    for (int i = 1; i < numbers.Length; i++)
    {
        lookFor = numbers[i];
        for (int j = 0; j < individuals.Length; j++)
        {
            if(lookFor==individuals[j])
            {
                flag = 1;
            }   
        }
        if(flag == 0) 
        {
            individuals+=lookFor.ToString();
            count++;
        }
        flag = 0;
    }
    return count;
}
bool KnownElementInFirstColumn(string lookFor, string [,] matrix)
{
    int flag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(matrix[i,0] == lookFor) flag = 1;
    }
    if(flag == 1) return true;
    else return false;
}
string [,] Frequencies (string numbers)
{
       
    int count = CountElements(numbers);
    string []element = new string [3];
    string [,] newMatrix  = new string [count,3];
    int i = 0;
    int j = 0;
    while (j < numbers.Length)
    {

        if (!KnownElementInFirstColumn(numbers[j].ToString(), newMatrix))
        {
            element = Frequency(numbers[j].ToString(), numbers); 
            newMatrix[i,0] = element[0];
            newMatrix[i,1] = element[1];
            newMatrix[i,2] = element[2];
            i++;
        }
        j++;
    }
    return newMatrix;
}
string text = "привет, ребята, как дела? Довольно неплохо. Но бывало же лучше?";

string [,] summary = Frequencies(text);
PrintArray(summary, "Итог:");