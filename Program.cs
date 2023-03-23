int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

string Print2DArray(int[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    Console.WriteLine();
    return res;
}

int[] SumRows(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sums[i] += array[i, j];
    return sums;
}

int IndexMin(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
        if(array[i] < array[minIndex]) minIndex = i;
    return minIndex;
}

int numRows = InputNum("Input a number of rows: ");
int numCols = InputNum("Input a numbers of columns: ");
int[,] myArray = Create2DArray(numRows, numCols);
int min = InputNum("Input a min value: ");
int max = InputNum("Input a max value: ");
Fill2DArray(myArray, min, max);
string firstArr = Print2DArray(myArray);
Console.WriteLine(firstArr);

int[] sums = SumRows(myArray);
int numRow = IndexMin(sums);
Console.WriteLine($"Number of row with min sum is {numRow + 1}");