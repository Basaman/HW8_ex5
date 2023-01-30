//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int number = 1;

int[,] array = GetArray(rows, columns);
fillArray(array);
printArray(array);

int[,] GetArray(int m, int n)
{

    int[,] array = new int[m, n];

    for (int y = 0; y < n; y++)
    {
        array[0, y] = number;
        number++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = number;
        number++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = number;
        number++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = number;
        number++;
    }
    return array;
}

void fillArray(int[,] matrix)
{
    int c = 1;
    int d = 1;
    while (number < rows * columns)
    {
        while (array[c, d + 1] == 0)
        {
            array[c, d] = number;
            number++;
            d++;
        }
        while (array[c + 1, d] == 0)
        {
            array[c, d] = number;
            number++;
            c++;
        }
        while (array[c, d - 1] == 0)
        {
            array[c, d] = number;
            number++;
            d--;
        }
        while (array[c - 1, d] == 0)
        {
            array[c, d] = number;
            number++;
            c--;
        }
    }

    for (int x = 0; x < rows; x++)
    {
        for (int y = 0; y < columns; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = number;
            }
        }
    }
}

void printArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}