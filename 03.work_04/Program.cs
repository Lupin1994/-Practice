Console.WriteLine("Write your number:");
int N = int.Parse(Console.ReadLine());
int i = 1;
double Mult = 1;
while (i <= N)
{
    Mult = Mult * i;
    i++;
    Console.WriteLine(Mult);
}
Console.WriteLine($"Your result is {Mult}");

// Console.WriteLine("Write your N:");
// int N = int.Parse(Console.ReadLine());
// double p = 1;
// for (int i = 1; i<=N;i++)
// {
//     p=p*i;
// }
// Console.WriteLine($"Your result is {p}");