// Показать число фибоначчи меньше заданного числа N
Console.WriteLine("Write N:");
int N = int.Parse(Console.ReadLine() ?? "0");

int FirstValue = 0;
int SecondValue = 1;
int result = 0;
//Console.Write($"{FirstValue} {SecondValue}");

while (FirstValue+SecondValue < N)
{
    result = FirstValue + SecondValue;
    Console.Write(result + " ");
    FirstValue = SecondValue;
    SecondValue = result;
}
