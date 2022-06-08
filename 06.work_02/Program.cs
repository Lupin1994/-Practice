// В двумерном массиве n×k заменить четные элементы на противоположные

void PrintMatrix(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            Console.Write($"{matr[n, k]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            matr[n, k] = new Random().Next(1, 10);
        }
    }
}
void ReplacementMatrix(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            if (matr[n, k] % 2 == 0) matr[n, k] = -matr[n, k];
        }
    }
}
int[,] matrix = new int[5, 5];
FillArray(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
ReplacementMatrix(matrix);
PrintMatrix(matrix);