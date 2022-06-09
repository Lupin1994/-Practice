// Написать программу масштабирования фигуры
// чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)".
int CountSpace(string str, char symbol)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == symbol)
        {
            count++;
        }
    }
    return count;
}
string[] Split(string str, char symbol)
{
    string[] coordinates = new string[CountSpace(str, symbol) + 1];
    int amount = 0;
    for (int i = 0; i < str.Length; i++)
    {
        while (i < str.Length && str[i] != symbol)
        {
            coordinates[amount] += str[i];
            i++;
        }
        amount++;
    }
    return coordinates;
}
//.................Для отладки............................
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
//..........................................................
string Substring(string str, int startIndex, int lastIndex)
{
    string result = " ";
    for (int i = startIndex;i < lastIndex; i++)
    {
        result += str[i];
    }
    return result;
}
int[,] ParsePoints(string[] coordinates)
{
    int[,] points = new int[coordinates.Length, 2];
    for (int i = 0; i < coordinates.Length; i++)
    {
        string substring = Substring(coordinates[i], 1, coordinates[i].Length - 1);
        string[] pointCoordinates = Split(substring,',');
        for(int j = 0;j<pointCoordinates.Length;j++)
        {
            points[i,j] = int.Parse(pointCoordinates[j]);
        }
    }

    return points;
}
Console.WriteLine("Enter coordinates of figure: ");
string input = Console.ReadLine() ?? "";
if (input == null || input.Length == 0)
{
    Console.WriteLine("Enter not empty string");

    return;
}
Console.WriteLine("Enter koefficient of scaling: ");
int k = int.Parse(Console.ReadLine()??"0");
string[] coordinates = Split(input, ' ');
int[,] points = ParsePoints(coordinates);
for(int i=0;i<points.GetLength(0);i++)
{
    Console.Write($"({points[i,0]*k}, {points[i,1]*k}) ");
}