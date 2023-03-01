// Написать программу масштабирования фигуры
// Вершины фигуры задать списком (одной строкой)
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// например: "(0,0) (2,0) (2,2) (0,2)"
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)
double ReadDouble(string text)
    {
        Console.Write(text);
        return double.Parse(Console.ReadLine()!);
    }

// int ReadInt(string text)
//     {
//         Console.Write(text);
//         return int.Parse(Console.ReadLine()!);
//     }

string ReadString(string text)
    {
        Console.Write(text);
        return Console.ReadLine()!;
    }

// void PrintArray(int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         Console.Write($" | {array[i]} | ");
//     }
// void Print2DArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(string.Format("{0} ", array[i, j]));
//             }
//             Console.WriteLine();
//         }
//     }

void Print2DCoordinatesArray(int[,] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count%2 == 0)
                {
                    Console.Write(string.Format("({0}", array[i, j]));
                    count++;
                }
                else
                {
                    Console.Write(string.Format(",{0}) ", array[i, j]));
                    count++;        
                }
            }
        }
        Console.Write("\n");
    }
void Print2DCoordinatesDoubleArray(double[,] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count%2 == 0)
                {
                    Console.Write(string.Format("({0}", array[i, j]));
                    count++;
                }
                else
                {
                    Console.Write(string.Format(",{0}) ", array[i, j]));
                    count++;        
                }
            }
        }
        Console.Write("\n");
    }


double[,] scaleFigure(int[,] array, double k)
    {
        double[,] newArray = new double[array.GetLength(0),array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 newArray[i,j]  = double.Parse(array[i,j].ToString())*k;
            }
        }
        return newArray;
    }

int[] stringToArray (string text)
    {
        int[] array = new int[text.Length];
        int number = 0;
        int count = 0; 
        int firstCharIsDigit = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsDigit(text[i])) 
            {
                firstCharIsDigit = 1;
                number= number*10 + (text[i]-'0');
                if (i == text.Length - 1) 
                {
                    array[count] = number;
                    number = 0;
                    firstCharIsDigit = 0;
                    // count++;                   
                }

            }
            else if(firstCharIsDigit != 0)
            {
                if (i != text.Length - 1) 
                {
                    array[count] = number;
                    number = 0;
                    firstCharIsDigit = 0;
                    count++;                   
                }
                else
                {
                    array[count] = number;
                }
            }

        }
        int[] newArray = new int[count+1];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }
int[,] ArrayTo2DArray (int[] array)
    {
  int[,] array2D = new int[array.Length/2,2];

        int switcher = 0;
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (switcher == 0) 
            {
                array2D[j,switcher] = array[i];
                switcher = 1;

            }
            else 
            {
                array2D[j,switcher] = array[i];
                switcher = 0;
                j++;
            }
        }
        return array2D;
    }

// PrintArray(stringToArray(text));
string text = ReadString("Введите координаты фигуры в виде (x1,y1),(x2,y2) ... (xn,yn): ");
Console.WriteLine("Введенные координаты образуют фигуру с точками: ");
Print2DCoordinatesArray(ArrayTo2DArray(stringToArray(text)));
double k = ReadDouble("Введите коэффициент масштабирования фигуры: ");
Print2DCoordinatesDoubleArray(scaleFigure(ArrayTo2DArray(stringToArray(text)),k));


