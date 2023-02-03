// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    double[,] newFilledArray = new double[rows, columns];
    Random Randomizer = new Random();

    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < columns; x++)
        {
            newFilledArray[y, x] = Randomizer.NextDouble() * Math.Pow(10, Randomizer.Next(2, 5));
        }
    }
    return newFilledArray;
}

void PrintArray(double[,] arrayForPrint)
{
    for (int y = 0; y < arrayForPrint.GetLength(0); y++)
    {
        for (int x = 0; x < arrayForPrint.GetLength(1); x++)
        {
            System.Console.Write(" {0,15:F4} ", arrayForPrint[y, x]);
        }
        System.Console.WriteLine();
    }
}

void Main()
{
    System.Console.Write("Программа сгенерирует массив вещественных числел по заданным размерам.\nВведите количество строк: ");
    int rowCount = int.Parse(Console.ReadLine());
    System.Console.Write("Введите количество столбцов: ");
    int columnCount = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    PrintArray(CreateArray(rowCount, columnCount));
}

Main();


