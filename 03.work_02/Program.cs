Console.WriteLine("Write your latest number:");
int a = int.Parse(Console.ReadLine());
int max = a;
int i = 0;
int inew = 0;
while (i <= max)
{
    inew = inew + i;
    Console.WriteLine(inew);
    i++;
}
// Console.WriteLine("Write your latest number:");
// int a = int.Parse(Console.ReadLine());
// int sum = a*(a+1)/2; // математическая формула по нахождению ариф прогрессии
// Console.WriteLine(sum);