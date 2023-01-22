/* ЗНапишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет. */
Console.Clear();

Console.Write("Введите индекс строки массива: ");
int mStr = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца массива: ");
int nColumn = int.Parse(Console.ReadLine());

int [,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
CheckInputArrayIndex(mStr, nColumn);

void CheckInputArrayIndex (int inputSrtIndex, int inputColumnIndex) {  // проверка существования элемента в массиве
    if (inputSrtIndex < 0 | inputSrtIndex > matrix.GetLength(0) - 1 | inputColumnIndex < 0 | inputColumnIndex > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else Console.WriteLine($"Значение элемента массива = {matrix[inputSrtIndex, inputColumnIndex]}");
}


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
            matr[i,j] = new Random().Next(-5, 5);
        }
    }
}
