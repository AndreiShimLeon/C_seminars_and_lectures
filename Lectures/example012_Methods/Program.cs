// Вид методов №1 - ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Андрей");
}

Method1(); // вызов метода Method1()

// Вид методов №2 - принимают аргументы, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i <count) 
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "текст", count: 5); // использование именованных аргументов позволяет использовать их не по порядку


// Вид методов №3 - ничего не принимают, но что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид методов №4 - что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "ку-ку ");
Console.WriteLine(res);

// Вывод таблицы умножения на экран
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i*j}");
        }
        Console.WriteLine();
    }

// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
// s[3] // r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText+ "\n");


// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText+ "\n");

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText+ "\n");

int[] arr = {1,5,2,3,4,11,4,3,2,6,7,7};

void PrintArray(int[] array) // метод печати массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) 
                minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);