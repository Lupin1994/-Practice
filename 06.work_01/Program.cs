// Показать двумерный массив размером m×n заполненный целыми числами
void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m,n]} ");
        }
    Console.WriteLine();    
    }
}
void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m,n] = new Random().Next(0,10);
        }   
    }
}
int[,] matrix = new int[3,6];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);