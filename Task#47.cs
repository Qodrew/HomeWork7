// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int mStr = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int nColumn = int.Parse(Console.ReadLine());

double [,] matrix = new double[mStr, nColumn];
FillArray(matrix);
PrintArray(matrix);


void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            var x = new Random().NextDouble() * new Random().Next(0, 9);
            matr[i,j] = Math.Round(x, 1);
        }
    }
}

