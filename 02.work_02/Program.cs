Console.WriteLine("Write X:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Write Y:");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("First quarter");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Second quarter");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Third quarter");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Fourth quarter");
}
else 
Console.WriteLine("Write X and Y wrong.");

// if (X > 0)
// {
//     if (Y > 0)
//     {
//         Console.WriteLine("First quarter");
//     }
//     else
//     {
//         Console.WriteLine("Fourth quarter");
//     }
// }
// else
// {
//     if (Y > 0)
//     {
//         Console.WriteLine("Second quarter");
//     }
//     else
//     {
//         Console.WriteLine("Third quarter");
//     }
// }