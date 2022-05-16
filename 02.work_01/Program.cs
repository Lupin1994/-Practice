Console.WriteLine("Write your number:");
int number = int.Parse(Console.ReadLine());

if (number%7==0 && number%23==0)
{
    Console.WriteLine($"{number} is multiple of 7 and 23");
}
else
{
    Console.WriteLine($"{number} isn't multiple of 7 and 23");
}