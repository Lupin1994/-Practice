Console.WriteLine("Введите 3-ех значное число:");
int a = int.Parse(Console.ReadLine());
if ( a > 99 && a<1000)
{
    int b = a % 10;
    Console.Write("3-тья цифра введенного числа:");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Число не 3-ех значное.");
}