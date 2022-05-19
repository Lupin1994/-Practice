Console.Write("Введите размер массива: ");

int Number = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[Number];

for (int i = 0; i < Number; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();   

int Sum = 0;

for(int i = 0; i<arr.Length;i++)
{
    if (i % 2 == 1)
    {
        Sum = Sum + arr[i];
    } 
}
Console.Write(Sum);