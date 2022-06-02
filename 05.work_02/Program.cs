//  Являются ли три числа сторонами треугольника
// a,b,c, являются треугольником если a+b>c и b+c>a и a+c>b
Console.WriteLine("Write number a: ");
int A = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number B: ");
int B = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number C: ");
int C = int.Parse(Console.ReadLine() ?? "0");
if (A + B > C && B + C > A && A + C > B)
{
    Console.WriteLine("This is triangle");
}
else
{
    Console.WriteLine("This is not triangle");
}
