Console.WriteLine("Write_number_1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write_number_2:");
int b = int.Parse(Console.ReadLine());
while (a <= b)
{
    Console.Write("[");
    Console.Write(a);
    Console.Write("],");
    a++;
}

// Console.WriteLine("Write_number:");
// int x = int.Parse(Console.ReadLine());

// int min = -x;
// while (min <= x)
// {
//     Console.Write(" " + min);
//     min++;
// }
