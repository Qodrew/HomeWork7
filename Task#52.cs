// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] matrix = new int[4,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintArrayAverage(matrix);


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 9);
        }
    }
}

void PrintArrayAverage(int[,] matr)
{
    Console.Write("Среднее арифметическое элементов в каждом столбце: ");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum += matr[i,j];
        }
        Console.Write($"{sum/matr.GetLength(0)}. ");
    }
}
