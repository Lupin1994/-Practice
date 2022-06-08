// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
// void PrintMatrix(int[,] matr)
// {
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             Console.Write($"{matr[n, k]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             matr[n, k] = new Random().Next(1, 10);
//         }
//     }
// }
// void SearchElementMatrix(int[,] matr, int num)
// {
//     bool check = false;
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             if (matr[n, k] == num) 
//             {Console.WriteLine($"Your number in array {matr[n, k]} in row{n} in colum {k}"); check = true;}
//         }
//     }
//     if (check == false) Console.WriteLine($"In array number {num} not found.");
// }
// Console.Clear();
// Console.WriteLine("Write row: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Write columns: ");
// int k = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix = new int[n, k];

// Console.WriteLine("Write searching number: ");
// int num = int.Parse(Console.ReadLine());

// FillArray(matrix);
// Console.WriteLine("Beginer array:");
// PrintMatrix(matrix);
// SearchElementMatrix(matrix, num);

//..................Решение лучше.............................
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
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
    return matrix;
}
int[]? IndexOf(int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)
            {
                return new int[2] { i, j };
            }
        }
    }
    return null;
}
Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix elements: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows, columns, start, finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.WriteLine("Enter value to find in matrix: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int[]? position = IndexOf(matrix, value);
if(position==null)
{
    Console.WriteLine("There is no value in matrix");
}
else
{
    Console.WriteLine($"Position of element: {position[0]} {position[1]}");
}
