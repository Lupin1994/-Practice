int[] array = { 2, 5, 8, 9, 3, 23, 4, 56, 68, 9, 5, 6 };
int len = array.Length;
Console.Write("Введите число:");
int value = int.Parse(Console.ReadLine());
for (int i = 0; i < len; i++)
{
    if (array[i] == value)
    {
        Console.Write($"число {value} = {i} найдено в массиве");
        return;
    }
    else if (i == len - 1) Console.Write($"число{value} не найдено в массиве");

}

// // Определить, присутствует ли в заданном массиве, некоторое число
// Console.Clear();
// int[] arr = {-3, 5, 2, 1211, 323, 5, -23, 4, -6};
// for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
// Console.WriteLine();
// Console.Write("Введите число для поиска в массиве: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int check = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == num)
//     {
//         Console.WriteLine($"Заданное число {num} найдено в массиве!");
//         check = 1;
//         break;
//     }
// }
// if (check == 0) Console.WriteLine($"Заданное число {num} не найдено в массиве!");