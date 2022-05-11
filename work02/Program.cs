
Console.WriteLine("Write_number_1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write_number_2:");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if (b>max)
{
   Console.Write("Max = ");
   Console.WriteLine(b);
   Console.Write("Min = ");
   Console.WriteLine(a);
}
else
{
   Console.Write("Max = ");
   Console.WriteLine(a);
   Console.Write("Min = ");
   Console.WriteLine(b);
}
