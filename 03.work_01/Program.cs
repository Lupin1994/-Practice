//.....................................................................................
// Console.WriteLine("Write your latest number:");
// int n = int.Parse(Console.ReadLine());
// int i = 0;
// int Q = 1;
// while (i < n)
// {
//     i++;
//     Q = i * i;
//     Console.Write($" [{i}],");
//     Console.WriteLine($" [{Q}],");
// }
//....................................................................................
Console.WriteLine("Write number:");
int max = int.Parse(Console.ReadLine());
int count = 1;
while(count <= max)
{
    Console.WriteLine(count*count);
    count++;
}
//....................................................................................
// Console.WriteLine("Write your latest number:");
// int n = int.Parse(Console.ReadLine());
// int count = 0;
// while (count<n)
// {
//     int digit = count +1;
//     Console.WriteLine($"Список квадратов чисел от 1 до {n} {digit*digit}");
//     count++;
// }
// .....................................................................................
//Console.WriteLine("Введите число n:");
// int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"{i * i} , ");
// }
