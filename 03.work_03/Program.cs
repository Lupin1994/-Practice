Console.WriteLine("Write your number:");
int a = int.Parse(Console.ReadLine());
int i = 0;
while (a > 0)
{
    a = a / 10;
    i++;
}
Console.WriteLine("Колличество цифр:" + i);
