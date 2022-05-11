
Console.WriteLine("Write_number_1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write_number_2:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Write_number_3:");
int c = int.Parse(Console.ReadLine());
int max = a;
int min = a;
if (b>max)
{
   max = b;
}
else
{
    min = b;
}
if (c>max)
{
    max = c;
}
else
{
    min = c;
}
Console.Write("Max = ");
Console.WriteLine(max);
Console.Write("Min = ");
Console.WriteLine(min);




